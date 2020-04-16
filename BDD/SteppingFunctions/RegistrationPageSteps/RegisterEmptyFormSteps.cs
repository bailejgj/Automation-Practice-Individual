using AutomationPractice.lib;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.BDD.SteppingFunctions.RegistrationPageSteps
{
    [Binding]
    public class RegisterEmptyFormSteps
    {
        private AutomationPracticeWebsite _automation;
        [Given(@"I am on the register page")]
        public void GivenIAmOnTheRegisterPage()
        {
            _automation.APSignIn.EnterREmail("gbg@gbg.gbg");
            _automation.APSignIn.SubmitREmail();
        }
        [Given(@"I enter no details")]
        public void GivenIEnterNoDetails()
        {
            
        }
        
        [Then(@"I receive (.*) errors")]
        public void ThenIReceiveErrors()
        {
            Assert.That(_automation.APRegister.ReadError(),
            Is.EqualTo("There are 8 errors"));
        }
    }
}
