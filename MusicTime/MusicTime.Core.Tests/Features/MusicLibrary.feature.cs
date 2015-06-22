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

using TechTalk.SpecFlow;

#pragma warning disable
namespace MusicTime.Core.Tests.Features
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Music Library")]
    public partial class MusicLibraryFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MusicLibrary.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Music Library", "In order to allow users to create their playlist\r\nAs an admin\r\nI want to be able " +
                    "to provide them a repository of songs", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Add new song")]
        public virtual void AddNewSong()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new song", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Name",
                        "My rock song"});
            table1.AddRow(new string[] {
                        "Description",
                        "A song I wrote for the world"});
            table1.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_25"});
            table1.AddRow(new string[] {
                        "Genre",
                        "Rock"});
#line 9
 testRunner.When("I add a new song with the following information", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "StreamId",
                        "Genre"});
            table2.AddRow(new string[] {
                        "My rock song",
                        "A song I wrote for the world",
                        "12345856_streamId_25",
                        "Rock"});
#line 15
 testRunner.Then("the music library should be as follows", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add new song without name")]
        public virtual void AddNewSongWithoutName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new song without name", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Name",
                        ""});
            table3.AddRow(new string[] {
                        "Description",
                        "A song I wrote for the world"});
            table3.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_25"});
            table3.AddRow(new string[] {
                        "Genre",
                        "Rock"});
#line 23
 testRunner.When("I add a new song with the following information", ((string)(null)), table3, "When ");
#line 29
 testRunner.Then("I should see an unsuccessful add song error message \'Name is required\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add new song without description")]
        public virtual void AddNewSongWithoutDescription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new song without description", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "Name",
                        "My rock song"});
            table4.AddRow(new string[] {
                        "Description",
                        ""});
            table4.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_25"});
            table4.AddRow(new string[] {
                        "Genre",
                        "Rock"});
#line 34
 testRunner.When("I add a new song with the following information", ((string)(null)), table4, "When ");
#line 40
 testRunner.Then("I should see an unsuccessful add song error message \'Description is required\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add new song without stream id")]
        public virtual void AddNewSongWithoutStreamId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new song without stream id", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Name",
                        "My rock song"});
            table5.AddRow(new string[] {
                        "Description",
                        "A song I wrote for the world"});
            table5.AddRow(new string[] {
                        "StreamId",
                        ""});
            table5.AddRow(new string[] {
                        "Genre",
                        "Rock"});
#line 45
 testRunner.When("I add a new song with the following information", ((string)(null)), table5, "When ");
#line 51
 testRunner.Then("I should see an unsuccessful add song error message \'StreamId is required\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add new song without genre")]
        public virtual void AddNewSongWithoutGenre()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new song without genre", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "Name",
                        "My rock song"});
            table6.AddRow(new string[] {
                        "Description",
                        "A song I wrote for the world"});
            table6.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_25"});
            table6.AddRow(new string[] {
                        "Genre",
                        ""});
#line 57
 testRunner.When("I add a new song with the following information", ((string)(null)), table6, "When ");
#line 63
 testRunner.Then("I should see an unsuccessful add song error message \'Genre is required\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a song without being admin")]
        public virtual void AddASongWithoutBeingAdmin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a song without being admin", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 66
 testRunner.Given("I am login as \'user@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Name",
                        "My rock song"});
            table7.AddRow(new string[] {
                        "Description",
                        "A song I wrote for the world"});
            table7.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_25"});
            table7.AddRow(new string[] {
                        "Genre",
                        "Rock"});
#line 67
 testRunner.When("I add a new song with the following information", ((string)(null)), table7, "When ");
#line 73
 testRunner.Then("I should recived an not authorized exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
