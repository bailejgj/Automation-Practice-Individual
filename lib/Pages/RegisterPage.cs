using System.Threading;
using AutomationProjectTestFramework;
using OpenQA.Selenium;

namespace AutomationPractice.lib.pages
{
    public class RegisterPage
    {

        private IWebDriver _driver;
        private string _loginPageUrl = AppConfigReader.LoginUrl;
        private IWebElement checkRegisterPage => this._driver.FindElement(By.ClassName("page-heading"));
        private IWebElement selectMale => this._driver.FindElement(By.Id("id_gender1"));
        private IWebElement selectFemale => this._driver.FindElement(By.Id("id_gender2"));
        private IWebElement enterFName => this._driver.FindElement(By.Id("customer_firstname"));
        private IWebElement enterLName => this._driver.FindElement(By.Id("customer_lastname"));
        private IWebElement enterEmail => this._driver.FindElement(By.Id("email"));
        private IWebElement enterPassword => this._driver.FindElement(By.Id("passwd"));
        private IWebElement selectDay => this._driver.FindElement(By.Id("uniform-days")).FindElement(By.Id("days"));
        private IWebElement selectMonth => this._driver.FindElement(By.Id("uniform-months")).FindElement(By.Id("months"));
        private IWebElement selectYear => this._driver.FindElement(By.Id("uniform-years")).FindElement(By.Id("years"));
        private IWebElement getNewsletter => this._driver.FindElement(By.Id("uniform-newsletter"));
        private IWebElement optIn => this._driver.FindElement(By.Id("uniform-optin"));
        private IWebElement enterAFName => this._driver.FindElement(By.Id("firstname"));
        private IWebElement enterALName => this._driver.FindElement(By.Id("lastname"));
        private IWebElement enterCompany => this._driver.FindElement(By.Id("company"));
        private IWebElement enterAddress1 => this._driver.FindElement(By.Id("address1"));
        private IWebElement enterAddress2 => this._driver.FindElement(By.Id("address2"));
        private IWebElement enterCity => this._driver.FindElement(By.Id("city"));
        private IWebElement selectState => this._driver.FindElement(By.Id("id_state"));
        private IWebElement enterPostcode => this._driver.FindElement(By.Id("postcode"));
        private IWebElement enterAdditionalInfo => this._driver.FindElement(By.Id("other"));
        private IWebElement enterHomePhone => this._driver.FindElement(By.Id("phone"));
        private IWebElement enterMobilePhone => this._driver.FindElement(By.Id("phone_mobile"));
        private IWebElement enterAlias => this._driver.FindElement(By.Id("alias"));
        private IWebElement submitAccount => this._driver.FindElement(By.Id("submitAccount"));
        private IWebElement errorMessage => this._driver.FindElement(By.ClassName("alert alert-danger"));

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public string CheckCurrentPage()
        {
            return checkRegisterPage.ToString();
        }
        //This method fills the 8 vital fields (Firstname, lastname, password, phone, address1, city, postcode and state)
        public void FillNonSensitiveFields()
        {
            selectMale.Click();
            enterFName.SendKeys("John");
            enterLName.SendKeys("Smith");
            enterPassword.SendKeys("Password");
            enterHomePhone.SendKeys("123456");
            enterAddress1.SendKeys("address");
            enterCity.SendKeys("city");
            selectState.SendKeys("Alabama");
            selectState.Submit();
            enterPostcode.SendKeys("00000");
        }
        public void SelectMale()
        {
            selectMale.Click();
        }
        public void SelecFemMale()
        {
            selectFemale.Click();
        }
        public void EnterFName(string FName)
        {
            enterFName.SendKeys(FName);
        }
        public void EnterLName(string LName)
        {
            enterLName.SendKeys(LName);
        }
        public void EnterEmail(string Email)
        {
            enterEmail.SendKeys(Email);
        }
        public void EnterPassword(string Password)
        {
            enterPassword.SendKeys(Password);
        }
        public void ChooseDay(string day)
        {
            selectDay.SendKeys(day);
        }
        public void ChooseMonth(string month)
        {
            selectMonth.SendKeys(month);
        }
        public void ChooseYear(string year)
        {
            selectYear.SendKeys(year);
        }
        public void OptInNewsletter()
        {
            getNewsletter.Click();
        }
        public void OptInDeals()
        {
            optIn.Click();
        }
        public void AddressFName(string FName)
        {
            enterAFName.SendKeys(FName);
        }
        public void AddressLName(string LName)
        {
            enterAFName.SendKeys(LName);
        }
        public void EnterAddress1(string Address1)
        {
            enterAddress1.SendKeys(Address1);
        }
        public void EnterAddress2(string Address2)
        {
            enterAddress2.SendKeys(Address2);
        }
        public void EnterCity(string City)
        {
            enterCity.SendKeys(City);
        }
        public void SelectState(string State)
        {
            selectState.SendKeys(State);
            selectState.Submit();
        }
        public void EnterPostCode(string Postcode)
        {
            enterPostcode.SendKeys(Postcode);
        }
        public void EnterAdditionalDetails(string Additional)
        {
            enterAdditionalInfo.SendKeys(Additional);
        }
        public void EnterHomePhone(string HomePhone)
        {
            enterHomePhone.SendKeys(HomePhone);
        }
        public void EnterMobileNumber(string MobilePhone)
        {
            enterMobilePhone.SendKeys(MobilePhone);
        }
        public void EnterAddressAlias(string Alias)
        {
            enterAlias.SendKeys(Alias);
        }
        public void EnterRegistration()
        {
            submitAccount.Click();
        }
        public string ReadError()
        {
            return errorMessage.Text.ToString();
        }
    }
}
