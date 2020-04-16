using AutomationPractice.lib;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.BDD.SteppingFunctions.RegistrationPageSteps
{
    [Binding]
    public class CompleteRegistrationStepsSteps
    {
        private AutomationPracticeWebsite _automation;
        [Given(@"I am on the register page")]
        public void GivenIAmOnTheRegisterPage()
        {
            _automation.APSignIn.EnterREmail("gbg@gbg.gbg");
            _automation.APSignIn.SubmitREmail();
        }
        
        [Given(@"I have entered valid values into all fields")]
        public void GivenIHaveEnteredValidValuesIntoAllFields()
        {
            _automation.APRegister.FillNonSensitiveFields();
        }
        
        [When(@"I press register")]
        public void WhenIPressRegister()
        {
            _automation.APRegister.EnterRegistration();
        }
        
        [Then(@"I am redirected to the my account page")]
        public void ThenIAmRedirectedToTheMyAccountPage()
        {
            Assert.That(_automation.APMyAccount.CheckPage(),
            Is.EqualTo("MY ACCOUNT"));
        }
    }
}
