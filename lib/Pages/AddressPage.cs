using OpenQA.Selenium;

namespace AutomationPractice.lib.pages
{
    public class AddressPage
    {
        private IWebDriver _driver;
        private IWebElement _addNewAddress => this._driver.FindElement(By.PartialLinkText("http://automationpractice.com/index.php?controller=address"));
        private IWebElement _proceedToCheckout => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/form/p/button/span"));

        public AddressPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickProceedToCheckout()
        {
            _proceedToCheckout.Click();
        }
        public void AddNewAddress()
        {
            _addNewAddress.Click();
        }
    }
}
