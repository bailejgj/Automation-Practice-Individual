using OpenQA.Selenium;

namespace AutomationPractice.lib.pages
{
    public class ForgotPasswordPage
    {
        private IWebDriver _driver;

        private IWebElement enterEmail => this._driver.FindElement(By.Id("email"));

        public ForgotPasswordPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void EnterEmail(string Email)
        {
            enterEmail.SendKeys(Email);
        }


    }
}
