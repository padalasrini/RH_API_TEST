﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Restful_Booker.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class BookingFeature : object, Xunit.IClassFixture<BookingFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Booking.feature"
#line hidden
        
        public BookingFeature(BookingFeature.FixtureData fixtureData, Restful_Booker_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Booking", "Create a room booking and verify the booking is successful", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="create a room booking and verify the booking is successful")]
        [Xunit.TraitAttribute("FeatureTitle", "Booking")]
        [Xunit.TraitAttribute("Description", "create a room booking and verify the booking is successful")]
        [Xunit.TraitAttribute("Category", "create_booking")]
        [Xunit.InlineDataAttribute("Srini", "Padala", "500", "True", "2023-11-22", "2023-11-24", "Breakfast", new string[0])]
        public void CreateARoomBookingAndVerifyTheBookingIsSuccessful(string firstName, string lastName, string totalPrice, string depositPaid, string checkIn, string checkOut, string additionalNeeds, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "create_booking"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("LastName", lastName);
            argumentsOfScenario.Add("TotalPrice", totalPrice);
            argumentsOfScenario.Add("DepositPaid", depositPaid);
            argumentsOfScenario.Add("CheckIn", checkIn);
            argumentsOfScenario.Add("CheckOut", checkOut);
            argumentsOfScenario.Add("AdditionalNeeds", additionalNeeds);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("create a room booking and verify the booking is successful", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "firstname",
                            "lastname",
                            "totalprice",
                            "depositpaid",
                            "checkin",
                            "checkout",
                            "additionalneeds"});
                table1.AddRow(new string[] {
                            string.Format("{0}", firstName),
                            string.Format("{0}", lastName),
                            string.Format("{0}", totalPrice),
                            string.Format("{0}", depositPaid),
                            string.Format("{0}", checkIn),
                            string.Format("{0}", checkOut),
                            string.Format("{0}", additionalNeeds)});
#line 7
testRunner.Given("I create a room booking using the CreateBooking API", ((string)(null)), table1, "Given ");
#line hidden
#line 10
testRunner.Then("I verify the booking is successful using GetBooking API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                BookingFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                BookingFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
