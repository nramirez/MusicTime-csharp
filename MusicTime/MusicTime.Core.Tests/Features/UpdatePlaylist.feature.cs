﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MusicTime.Core.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Update Playlist")]
    public partial class UpdatePlaylistFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdatePlaylist.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Update Playlist", "In order to have my music organized\r\nAs a user\r\nI want to be able to rename the p" +
                    "roperties of my playlists", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Playlist correctly")]
        public virtual void UpdatePlaylistCorrectly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Playlist correctly", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I am login as \'user@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Property"});
            table1.AddRow(new string[] {
                        "Name",
                        "My coding rock"});
            table1.AddRow(new string[] {
                        "Description",
                        "code like a Rockstar"});
#line 8
 testRunner.And("I have the following playlist in my list", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Property"});
            table2.AddRow(new string[] {
                        "Name",
                        "My coding music"});
            table2.AddRow(new string[] {
                        "Description",
                        "Rock for Rockstars"});
#line 12
 testRunner.When("I update this playlist with the following information", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table3.AddRow(new string[] {
                        "My coding music",
                        "Rock for Rockstars"});
#line 16
 testRunner.Then("My playlist list should be as follows", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Playlist with empty name fails")]
        public virtual void UpdatePlaylistWithEmptyNameFails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Playlist with empty name fails", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("I am login as \'user@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Property"});
            table4.AddRow(new string[] {
                        "Name",
                        "My coding rock"});
            table4.AddRow(new string[] {
                        "Description",
                        "code like a Rockstar"});
#line 22
 testRunner.And("I have the following playlist in my list", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Property"});
            table5.AddRow(new string[] {
                        "Name",
                        ""});
            table5.AddRow(new string[] {
                        "Description",
                        "Rock for Rockstars"});
#line 26
 testRunner.When("I update this playlist with the following information", ((string)(null)), table5, "When ");
#line 30
 testRunner.Then("I should see an unsuccessful update playlist error message \'Name is required\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Playlist with empty description fails")]
        public virtual void UpdatePlaylistWithEmptyDescriptionFails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Playlist with empty description fails", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
 testRunner.Given("I am login as \'user@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Property"});
            table6.AddRow(new string[] {
                        "Name",
                        "My coding rock"});
            table6.AddRow(new string[] {
                        "Description",
                        "code like a Rockstar"});
#line 35
 testRunner.And("I have the following playlist in my list", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Property"});
            table7.AddRow(new string[] {
                        "Name",
                        "Rock and Code"});
            table7.AddRow(new string[] {
                        "Description",
                        ""});
#line 39
 testRunner.When("I update this playlist with the following information", ((string)(null)), table7, "When ");
#line 43
 testRunner.Then("I should see an unsuccessful update playlist error message \'Description is requir" +
                    "ed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
