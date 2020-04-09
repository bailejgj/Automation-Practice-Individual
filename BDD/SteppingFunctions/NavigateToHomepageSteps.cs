using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.BDD.SteppingFunctions
{
    [Binding]
    public class NavigateToHomepageSteps
    {
        [Given(@"I have a working computer and connection")]
        public void GivenIHaveAWorkingComputerAndConnection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the HomePage url")]
        public void WhenIEnterTheHomePageUrl()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am redirected to the HomePage")]
        public void ThenIAmRedirectedToTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
