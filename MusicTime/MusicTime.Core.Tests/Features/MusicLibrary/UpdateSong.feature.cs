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
namespace MusicTime.Core.Tests.Features.MusicLibrary
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Update Song information")]
    public partial class UpdateSongInformationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdateSong.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Update Song information", "In order to allow users to create their playlist\r\nAs an admin\r\nI want to be able " +
                    "to update my song repository", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Update a song")]
        public virtual void UpdateASong()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a song", ((string[])(null)));
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
 testRunner.And("the following song is in my library", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Name",
                        "My 90s song"});
            table2.AddRow(new string[] {
                        "Description",
                        "A song I wrote for you"});
            table2.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_57"});
            table2.AddRow(new string[] {
                        "Genre",
                        "Salsa"});
#line 15
 testRunner.When("I update this song information as follows", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "StreamId",
                        "Genre"});
            table3.AddRow(new string[] {
                        "My 90s song",
                        "A song I wrote for you",
                        "12345856_streamId_57",
                        "Salsa"});
#line 21
 testRunner.Then("the music library should be as follows", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update a song without name")]
        public virtual void UpdateASongWithoutName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a song without name", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "Name",
                        "My 90s song"});
            table4.AddRow(new string[] {
                        "Description",
                        "A song I wrote for you"});
            table4.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_57"});
            table4.AddRow(new string[] {
                        "Genre",
                        "Salsa"});
#line 29
 testRunner.And("the following song is in my library", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Name",
                        ""});
            table5.AddRow(new string[] {
                        "Description",
                        "A song I wrote for you"});
            table5.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_57"});
            table5.AddRow(new string[] {
                        "Genre",
                        "Salsa"});
#line 35
 testRunner.When("I update this song information as follows", ((string)(null)), table5, "When ");
#line 41
 testRunner.Then("I should see an unsuccessful error message \'Name is required\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update a song without description")]
        public virtual void UpdateASongWithoutDescription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a song without description", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "Name",
                        "My 90s song"});
            table6.AddRow(new string[] {
                        "Description",
                        "A song I wrote for you"});
            table6.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_57"});
            table6.AddRow(new string[] {
                        "Genre",
                        "Salsa"});
#line 46
 testRunner.And("the following song is in my library", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Name",
                        "My rock song"});
            table7.AddRow(new string[] {
                        "Description",
                        ""});
            table7.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_25"});
            table7.AddRow(new string[] {
                        "Genre",
                        "Rock"});
#line 52
 testRunner.When("I update this song information as follows", ((string)(null)), table7, "When ");
#line 58
 testRunner.Then("I should see an unsuccessful error message \'Description is required\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update a song without stream id")]
        public virtual void UpdateASongWithoutStreamId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a song without stream id", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 61
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 62
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "Name",
                        "My 90s song"});
            table8.AddRow(new string[] {
                        "Description",
                        "A song I wrote for you"});
            table8.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_57"});
            table8.AddRow(new string[] {
                        "Genre",
                        "Salsa"});
#line 63
 testRunner.And("the following song is in my library", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "Name",
                        "My rock song"});
            table9.AddRow(new string[] {
                        "Description",
                        "A song I wrote for the world"});
            table9.AddRow(new string[] {
                        "StreamId",
                        ""});
            table9.AddRow(new string[] {
                        "Genre",
                        "Rock"});
#line 69
 testRunner.When("I update this song information as follows", ((string)(null)), table9, "When ");
#line 75
 testRunner.Then("I should see an unsuccessful error message \'StreamId is required\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update a song without genre")]
        public virtual void UpdateASongWithoutGenre()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a song without genre", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "Name",
                        "My 90s song"});
            table10.AddRow(new string[] {
                        "Description",
                        "A song I wrote for you"});
            table10.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_57"});
            table10.AddRow(new string[] {
                        "Genre",
                        "Salsa"});
#line 81
 testRunner.And("the following song is in my library", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "Name",
                        "My rock song"});
            table11.AddRow(new string[] {
                        "Description",
                        "A song I wrote for the world"});
            table11.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_25"});
            table11.AddRow(new string[] {
                        "Genre",
                        ""});
#line 87
 testRunner.When("I update this song information as follows", ((string)(null)), table11, "When ");
#line 93
 testRunner.Then("I should see an unsuccessful error message \'Genre is required\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update a song without being admin")]
        public virtual void UpdateASongWithoutBeingAdmin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a song without being admin", ((string[])(null)));
#line 95
this.ScenarioSetup(scenarioInfo);
#line 96
 testRunner.Given("I am login as \'admin@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
 testRunner.And("I have the \'Admin\' role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "Name",
                        "My 90s song"});
            table12.AddRow(new string[] {
                        "Description",
                        "A song I wrote for you"});
            table12.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_57"});
            table12.AddRow(new string[] {
                        "Genre",
                        "Salsa"});
#line 98
 testRunner.And("the following song is in my library", ((string)(null)), table12, "And ");
#line 104
 testRunner.And("my friend login as \'myfriend@mail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "Name",
                        "My rock song"});
            table13.AddRow(new string[] {
                        "Description",
                        "A song I wrote for the world"});
            table13.AddRow(new string[] {
                        "StreamId",
                        "12345856_streamId_25"});
            table13.AddRow(new string[] {
                        "Genre",
                        "Rock"});
#line 105
 testRunner.When("he tries to update this song information as follows", ((string)(null)), table13, "When ");
#line 111
 testRunner.Then("I should recived an not authorized exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
