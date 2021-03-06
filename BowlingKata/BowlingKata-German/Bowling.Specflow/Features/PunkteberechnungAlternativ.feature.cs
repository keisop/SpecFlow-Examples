// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bowling.Specflow.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PunkteberechnungMitAlternativenDefinitionenFeature : Xunit.IClassFixture<PunkteberechnungMitAlternativenDefinitionenFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PunkteberechnungAlternativ.feature"
#line hidden
        
        public PunkteberechnungMitAlternativenDefinitionenFeature(PunkteberechnungMitAlternativenDefinitionenFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("de"), "Punkteberechnung (mit alternativen Definitionen)", "    Als Spieler\r\n    Will ich, dass das System meine Punktezahl berechnet\r\n    Da" +
                    "mit ich weiss wie gut ich bin", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Ein einziger Spare")]
        [Xunit.TraitAttribute("FeatureTitle", "Punkteberechnung (mit alternativen Definitionen)")]
        [Xunit.TraitAttribute("Description", "Ein einziger Spare")]
        public virtual void EinEinzigerSpare()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ein einziger Spare", null, ((string[])(null)));
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 10
    testRunner.When("ich folgende Serie werfe: 3,7,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 11
    testRunner.Then("soll meine Punktzahl 29 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Nur Spares")]
        [Xunit.TraitAttribute("FeatureTitle", "Punkteberechnung (mit alternativen Definitionen)")]
        [Xunit.TraitAttribute("Description", "Nur Spares")]
        public virtual void NurSpares()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nur Spares", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 15
    testRunner.When("ich 10 mal 1 und 9 werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 16
    testRunner.And("ich 1 werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Und ");
#line 17
    testRunner.Then("soll meine Punktzahl 110 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Noch ein weiteres Anfänger-Spiel")]
        [Xunit.TraitAttribute("FeatureTitle", "Punkteberechnung (mit alternativen Definitionen)")]
        [Xunit.TraitAttribute("Description", "Noch ein weiteres Anfänger-Spiel")]
        public virtual void NochEinWeiteresAnfanger_Spiel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Noch ein weiteres Anfänger-Spiel", null, ((string[])(null)));
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Pins"});
            table1.AddRow(new string[] {
                        "2"});
            table1.AddRow(new string[] {
                        "7"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "5"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "3"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "4"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "8"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
#line 21
    testRunner.When("ich werfe", ((string)(null)), table1, "Wenn ");
#line 43
    testRunner.Then("soll meine Punktzahl 43 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PunkteberechnungMitAlternativenDefinitionenFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PunkteberechnungMitAlternativenDefinitionenFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
