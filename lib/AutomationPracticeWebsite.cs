using AutomationPractice.lib.pages;
using OpenQA.Selenium;
using AutomationProjectTestFramework.lib.driver_config;

namespace AutomationPractice.lib
{
    class AutomationPracticeWebsite
    {
        //Accessible read only page objects
        public readonly HomePage APHome;
        public readonly BasketPage APBasket;
        public readonly RegisterPage APRegister;
        public readonly AddressPage APAddress;
        public readonly DressPage APDress;
        public readonly MyAccountPage APMyAccount;
        public readonly OrderSummaryPage APOrderSummary;
        public readonly SignInPage APSignIn;
        public readonly PaymentMethodPage APPaymentMethod;
        public readonly ShippingPage APShipping;
        public readonly OrderCompletionPage APCompletion;
        public readonly IWebDriver seleniumDriver;

        //Constructor for driver and config for the service
        public AutomationPracticeWebsite(string drivername, int pageLoadWaitInSecs = 10, int implicitWaitTimeInSecs = 10)
        {
            //Instantiation of driver
            seleniumDriver = new SeleniumDriverConfig(drivername, pageLoadWaitInSecs, implicitWaitTimeInSecs).Driver;

            //Instantiation of page objects with the selenium driver
            APHome = new HomePage(seleniumDriver);
            APBasket = new BasketPage(seleniumDriver);
            APRegister = new RegisterPage(seleniumDriver);
            APAddress = new AddressPage(seleniumDriver);
            APDress = new DressPage(seleniumDriver);
            APMyAccount = new MyAccountPage(seleniumDriver);
            APOrderSummary = new OrderSummaryPage(seleniumDriver);
            APSignIn = new SignInPage(seleniumDriver);
            APPaymentMethod = new PaymentMethodPage(seleniumDriver);
            APShipping = new ShippingPage(seleniumDriver);
            APCompletion = new OrderCompletionPage(seleniumDriver);
        }
    }
}
