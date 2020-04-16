using System;
using TechTalk.SpecFlow;
using AutomationPractice.lib.pages;
using AutomationPractice.lib;

namespace AutomationPractice.BDD.SteppingFunctions
{
    [Binding]
    public class NavigateToHomepageSteps
    {
        private AutomationPracticeWebsite _automation;
        [Given(@"I have a working computer and connection")]
        public void GivenIHaveAWorkingComputerAndConnection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the HomePage url")]
        public void WhenIEnterTheHomePageUrl()
        {
            _automation.APHome.VisitHomePage();
        }
        
        [Then(@"I am redirected to the HomePage")]
        public void ThenIAmRedirectedToTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
