using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.BDD.SteppingFunctions
{
    [Binding]
    public class NavigateToLoginSteps
    {
        [Given(@"I am on the HomePage")]
        public void GivenIAmOnTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press signin")]
        public void WhenIPressSignin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am redirected to the SignIn")]
        public void ThenIAmRedirectedToTheSignIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
