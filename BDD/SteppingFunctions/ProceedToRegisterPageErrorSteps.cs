using System;
using TechTalk.SpecFlow;
using AutomationPractice.lib;

namespace AutomationPractice.BDD.SteppingFunctions
{
    [Binding]
    public class ProceedToRegisterPageErrorSteps
    {
        private AutomationPracticeWebsite _automation;
        [Given(@"I am on the SigInPage")]
        public void GivenIAmOnTheSigInPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered an email without an at sign")]
        public void GivenIHaveEnteredAnEmailWithoutAnAtSign()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am given the error ""(.*)""")]
        public void ThenIAmGivenTheError(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
