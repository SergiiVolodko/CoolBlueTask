﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CoolBlueTask.Tests.Scenarios.SalesCombinations
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SalesCombinationsFlowFeature : Xunit.IClassFixture<SalesCombinationsFlowFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SalesCombinationsFlow.feature"
#line hidden
        
        public SalesCombinationsFlowFeature(SalesCombinationsFlowFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SalesCombinationsFlow", "\tIn order to sell more goods\r\n\tAs a shop owner\r\n\tJeff should be able to combine r" +
                    "elated products into propositions for customers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Get products sales combinations")]
        [Xunit.TraitAttribute("FeatureTitle", "SalesCombinationsFlow")]
        [Xunit.TraitAttribute("Description", "Get products sales combinations")]
        public virtual void GetProductsSalesCombinations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get products sales combinations", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "product"});
            table1.AddRow(new string[] {
                        "Laptop"});
            table1.AddRow(new string[] {
                        "Mouse"});
            table1.AddRow(new string[] {
                        "Headset"});
            table1.AddRow(new string[] {
                        "Keyboard"});
#line 7
 testRunner.Given("Jeff has related products in his store", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Main product",
                        "Related product 1",
                        "Related product 2"});
            table2.AddRow(new string[] {
                        "Laptop",
                        "Mouse",
                        "Keyboard"});
            table2.AddRow(new string[] {
                        "Laptop",
                        "Headset",
                        ""});
#line 13
 testRunner.When("He defines combinations of these products", ((string)(null)), table2, "When ");
#line 17
 testRunner.And("customer observes \'Laptop\' product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("customer sees defined by Jeff products suggestions for \'Laptop\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Create invalid Sales Combination")]
        [Xunit.TraitAttribute("FeatureTitle", "SalesCombinationsFlow")]
        [Xunit.TraitAttribute("Description", "Create invalid Sales Combination")]
        [Xunit.InlineDataAttribute("Empty input", new string[0])]
        [Xunit.InlineDataAttribute("Main product missed", new string[0])]
        [Xunit.InlineDataAttribute("Not existing main product", new string[0])]
        [Xunit.InlineDataAttribute("Related products missed", new string[0])]
        [Xunit.InlineDataAttribute("One of the related products does not exist", new string[0])]
        public virtual void CreateInvalidSalesCombination(string wrongCombinationInput, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create invalid Sales Combination", exampleTags);
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("Jeff has \'Pen\' and \'Paper\' products in his store", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.When(string.Format("he tries to create a sale combination by entering {0}", wrongCombinationInput), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("Jeff should see corresponding errors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SalesCombinationsFlowFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SalesCombinationsFlowFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion