﻿using AutomationProjectTestFramework;
using OpenQA.Selenium;

namespace AutomationPractice.lib.pages
{
    public class OrderSummaryPage
    {
        private IWebDriver _driver;
        private string _homePageUrl = AppConfigReader.BaseUrl;

        //CONFIRM ORDER BUTTON
        private IWebElement ConfirmOrderButton => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/form/p/button/span"));

        public OrderSummaryPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(_homePageUrl);
        }

        public void ClickConfirmOrder()
        {
            ConfirmOrderButton.Click();
        }
    }
}
