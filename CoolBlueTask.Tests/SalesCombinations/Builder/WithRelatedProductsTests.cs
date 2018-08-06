using System.Collections.Generic;
using CoolBlueTask.Products;
using CoolBlueTask.Products.Models;
using CoolBlueTask.SalesCombinations;
using CoolBlueTask.Tests.Infrastructure;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using NSubstitute;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace CoolBlueTask.Tests.SalesCombinations.Builder
{
	public class WithRelatedProductsTests
	{
		[Theory]
		[AutoNSubstituteData]
		public void calls_product_repo_exists_every_related_product_id(
			[Frozen] IProductRepository productRepo,
			SalesCombinationBuilder sut,
			IList<string> relatedProductsIds)
		{
			// Arrange
			productRepo.Exists(Arg.Any<string>()).Returns(true);

			// Act
			sut.WithRelatedProducts(relatedProductsIds);

			// Assert
			productRepo.Received(3)
				.Exists(Arg.Is<string>(i => relatedProductsIds.Contains(i)));
		}

		[Theory]
		[AutoNSubstituteData]
		public void if_any_related_product_not_exist_throws(
			[Frozen] IProductRepository productRepo,
			SalesCombinationBuilder sut,
			IList<string> relatedProductsIds)
		{
			// Arrange
			productRepo.Exists(relatedProductsIds[0]).Returns(true);
			productRepo.Exists(relatedProductsIds[1]).Returns(false);
			productRepo.Exists(relatedProductsIds[2]).Returns(true);

			var failures = new List<ValidationFailure>
			{
				new ValidationFailure("RelatedProducts", "A related product does not exist.")
				{
					ErrorCode = "not_existing_related_product"
				}
			};

			// Act
			// Assert
			sut.Invoking(s => s.WithRelatedProducts(relatedProductsIds))
				.ShouldThrow<ValidationException>()
				.And
				.Errors.ShouldBeEquivalentTo(failures);
		}

		[Theory]
		[AutoNSubstituteData]
		public void calls_product_repo_load_every_related_product_by_id(
			[Frozen] IProductRepository productRepo,
			SalesCombinationBuilder sut,
			IList<string> relatedProductsIds)
		{
			// Arrange
			productRepo.Exists(Arg.Any<string>()).Returns(true);

			// Act
			sut.WithRelatedProducts(relatedProductsIds);

			// Assert
			productRepo.Received(3)
				.LoadById(Arg.Is<string>(i => relatedProductsIds.Contains(i)));
		}

		[Theory]
		[AutoNSubstituteData]
		public void on_build_assigns_loaded_products_as_combination_related_products(
			[Frozen] IProductRepository productRepo,
			SalesCombinationBuilder sut,
			IList<string> relatedProductsIds,
			List<Product> loadedProducts)
		{
			// Arrange
			productRepo.Exists(Arg.Any<string>()).Returns(true);
			productRepo.LoadById(relatedProductsIds[0]).Returns(loadedProducts[0]);
			productRepo.LoadById(relatedProductsIds[1]).Returns(loadedProducts[1]);
			productRepo.LoadById(relatedProductsIds[2]).Returns(loadedProducts[2]);

			// Act
			var actual = sut.WithRelatedProducts(relatedProductsIds)
				.Build();

			// Assert
			actual.RelatedProducts
				.ShouldAllBeEquivalentTo(loadedProducts);
		}
	}
}
