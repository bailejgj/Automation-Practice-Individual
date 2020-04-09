using OpenQA.Selenium;
using System.Threading;


namespace AutomationPractice.lib.pages
{
    public class SignInPage
    {
        private IWebDriver _driver;
        private IWebElement _usernameField => _driver.FindElement(By.Id("email"));
        private IWebElement _passwordField => _driver.FindElement(By.Id("passwd"));
        private IWebElement EmailInput => this._driver.FindElement(By.Id("email_create"));
        private IWebElement ErrorBox => this._driver.FindElement(By.Id("create_account_error"));
        private IWebElement _confirmationButton => _driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/div/div[2]/form/div/p[2]/button/span"));

        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }
        //For Logging in
        public void EnterValidEmail(string email)
        {
            _usernameField.SendKeys(email);
        }

        public void EnterValidPassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void ConfirmationButton()
        {
            _confirmationButton.Click();
        }
        // For registering
        public void EnterREmail(string rEmail)
        {
            EmailInput.SendKeys(rEmail);
        }
        public void Clickoff()
        {
            Thread.Sleep(100);
            EmailInput.SendKeys(Keys.Tab);
        }
    }
}
