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
namespace MusicTime.Core.Tests.Features.Playlist
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Remove Song From Playlist")]
    public partial class RemoveSongFromPlaylistFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RemoveSongFromPlaylist.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Remove Song From Playlist", "In order to maintain my playlist clean\r\nAs a user\r\nI want to be able to remove so" +
                    "ngs", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Remove song from playlist")]
        public virtual void RemoveSongFromPlaylist()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Remove song from playlist", ((string[])(null)));
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
                        "My coding music"});
            table1.AddRow(new string[] {
                        "Description",
                        "code like a Rockstar"});
#line 8
 testRunner.And("I have the following playlist in my list", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "StreamId",
                        "Genre"});
            table2.AddRow(new string[] {
                        "A random song",
                        "A song I wrote for the world",
                        "12345856_streamId_25",
                        "Rock"});
            table2.AddRow(new string[] {
                        "Another random song",
                        "A song My brother wrote",
                        "15345856_streamId_27",
                        "Salsa"});
            table2.AddRow(new string[] {
                        "Another song",
                        "A song from my mom",
                        "15345856_streamId_29",
                        "Acoustic"});
#line 12
 testRunner.And("\'My coding music\' playlist has the following songs", ((string)(null)), table2, "And ");
#line 17
 testRunner.When("I clicked to remove the song \'Another random song\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "StreamId",
                        "Genre"});
            table3.AddRow(new string[] {
                        "A random song",
                        "A song I wrote for the world",
                        "12345856_streamId_25",
                        "Rock"});
            table3.AddRow(new string[] {
                        "Another song",
                        "A song from my mom",
                        "15345856_streamId_29",
                        "Acoustic"});
#line 18
 testRunner.Then("songs in my \'My coding music\' playlist should be as follow", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
