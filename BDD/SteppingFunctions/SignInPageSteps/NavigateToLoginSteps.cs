using AutomationPractice.lib;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.BDD.SteppingFunctions
{
    [Binding]
    public class NavigateToLoginSteps
    {
        private AutomationPracticeWebsite _automation;
        [Given(@"I am on the HomePage")]
        public void GivenIAmOnTheHomePage()
        {
            _automation.APHome.VisitHomePage();
        }
        
        [When(@"I press signin")]
        public void WhenIPressSignin()
        {
            _automation.APHome.ClickSignInLink();
        }
        
        [Then(@"I am redirected to the SignIn")]
        public void ThenIAmRedirectedToTheSignIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
