using AutomationProjectTestFramework;
using OpenQA.Selenium;
using System.Threading;


namespace AutomationPractice.lib.pages
{
    public class SignInPage
    {
        private string _loginUrl = AppConfigReader.LoginUrl;
        private IWebDriver _driver;
        private IWebElement _usernameField => _driver.FindElement(By.Id("email"));
        private IWebElement _passwordField => _driver.FindElement(By.Id("passwd"));
        private IWebElement _registerEmail => this._driver.FindElement(By.Id("email_create"));
        private IWebElement _submitRegister => this._driver.FindElement(By.Id("email_create"));
        private IWebElement _errorBox => this._driver.FindElement(By.Id("create_account_error"));
        private IWebElement _confirmationButton => _driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/div/div[2]/form/div/p[2]/button/span"));

        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void VisitLoginPage()
        {
            _driver.Navigate().GoToUrl(_loginUrl);
        }
        //For Logging in
        public void FullLogin()
        {
            EnterValidEmail("mitclork@mitclork.com");
            EnterValidPassword("mitclork");
            ConfirmationButton();
        }
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
            _registerEmail.SendKeys(rEmail);
            Thread.Sleep(100);
            _registerEmail.SendKeys(Keys.Tab);
        }
        public void SubmitREmail()
        {
            _submitRegister.Click();
        }
        public string ReadError()
        {
            return _errorBox.Text.ToString();
        }
    }
}
