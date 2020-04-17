using AutomationPractice.lib;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.BDD.SteppingFunctions.AddressPageSteps
{
    [Binding]
    public class AddingANewAddressSteps
    {
        private AutomationPracticeWebsite _automation;
        [Given(@"I have signed in")]
        public void GivenIHaveSignedIn()
        {
            _automation.APSignIn.FullLogin();
        }
        
        [Given(@"I am on the address page")]
        public void GivenIAmOnTheAddressPage()
        {
            _automation.APMyAccount.NavigateToAddress();
        }
        
        [When(@"I press Add a New Address")]
        public void WhenIPressAddANewAddress()
        {
            _automation.APAddress.AddNewAddress();
        }
        
        [Then(@"I am redirected to a new address page")]
        public void ThenIAmRedirectedToANewAddressPage()
        {
            
        }
    }
}
