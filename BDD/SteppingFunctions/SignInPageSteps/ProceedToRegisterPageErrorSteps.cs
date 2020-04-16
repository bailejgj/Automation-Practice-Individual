using System;
using TechTalk.SpecFlow;
using AutomationPractice.lib;
using NUnit.Framework;

namespace AutomationPractice.BDD.SteppingFunctions
{
    [Binding]
    public class ProceedToRegisterPageErrorSteps
    {
        private AutomationPracticeWebsite _automation;
        [Given(@"I am on the SigInPage")]
        public void GivenIAmOnTheSigInPage()
        {
            _automation.APSignIn.VisitLoginPage();
        }
        [When(@"I submit an invalid email")]
        public void WhenISubmitAnInvalidEmail()
        {
            _automation.APSignIn.EnterREmail("abc.abcdw");
        }
        [Then(@"I am given the error ""(.*)""")]
        public void ThenIAmGivenTheError()
        {
            Assert.That(_automation.APSignIn.ReadError(),
                Is.EqualTo("CREATE AN ACCOUNT"));
        }
    }
}
