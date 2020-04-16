using System;
using TechTalk.SpecFlow;
using AutomationPractice.lib;
using AutomationPractice.lib.pages;
using NUnit.Framework;

namespace AutomationPractice.BDD.SteppingFunctions
{
    [Binding]
    public class ProceedToRegisterPageSteps
    {
        private AutomationPracticeWebsite _automation;
        [Given(@"I am on the SignInPage")]
        public void GivenIAmOnTheSignInPage()
        {
            _automation.APSignIn.VisitLoginPage();
        }
        
        [Given(@"I have entered a valid email address")]
        public void GivenIHaveEnteredAValidEmailAddress()
        {
            _automation.APSignIn.EnterREmail("abc@abc.com");
        }
        
        [When(@"I click create account")]
        public void WhenIClickCreateAccount()
        {
            _automation.APSignIn.SubmitREmail();
        }
        
        [Then(@"I am redirected to the RegisterPage")]
        public void ThenIAmRedirectedToTheRegisterPage()
        {
            Assert.That(_automation.APRegister.CheckCurrentPage(),
                Is.EqualTo("CREATE AN ACCOUNT"));
        }
    }
}
