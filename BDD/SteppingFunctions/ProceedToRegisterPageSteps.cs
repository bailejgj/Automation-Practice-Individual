using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.BDD.SteppingFunctions
{
    [Binding]
    public class ProceedToRegisterPageSteps
    {
        [Given(@"I am on the SignInPage")]
        public void GivenIAmOnTheSignInPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a valid email address")]
        public void GivenIHaveEnteredAValidEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
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
        
        [When(@"I click create account")]
        public void WhenIClickCreateAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am redirected to the RegisterPage")]
        public void ThenIAmRedirectedToTheRegisterPage()
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
