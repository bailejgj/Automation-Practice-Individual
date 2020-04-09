using OpenQA.Selenium;

namespace AutomationPractice.lib.pages
{
    public class PaymentMethodPage
    {
        private IWebDriver _driver;

        private IWebElement _bankWireTransfer => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/div/div[3]/div[1]/div/p/a"));
        private IWebElement _checkTransfer => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?fc=module&amp;module=cheque&amp;controller=payment"));

        public PaymentMethodPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void PayByBankWire()
        {
            _bankWireTransfer.Click();
        }

        public void PayByCheck()
        {
            _checkTransfer.Click();
        }
    }
}

