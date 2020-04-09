using OpenQA.Selenium;

namespace AutomationPractice.lib.pages
{
    public class DressPage
    {
        private IWebDriver _driver;

        private IWebElement AddToCart => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div[2]/ul/li[1]/div/div[2]/div[2]/a[1]/span"));
        private IWebElement ProceedToCheckout => this._driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a/span"));

        public DressPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void AddProduct()
        {
            AddToCart.Click();
        }

        public void ProceedToCart()
        {
            ProceedToCheckout.Click();
        }
    }
}