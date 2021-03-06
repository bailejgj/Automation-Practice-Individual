﻿using OpenQA.Selenium;

namespace AutomationPractice.lib.pages
{
    public class MyAccountPage
    {
        private IWebDriver _driver;
        private IWebElement _searchBar => this._driver.FindElement(By.Id("search_query_top"));
        private IWebElement checkMyAccountPage => this._driver.FindElement(By.ClassName("page-heading"));
        private IWebElement addressPageLink => this._driver.FindElement(By.PartialLinkText("http://automationpractice.com/index.php?controller=addresses"));

        public MyAccountPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SearchProduct(string product)
        {
            _searchBar.SendKeys(product);
            _searchBar.Submit();
        }
        public string CheckPage()
        {
            return checkMyAccountPage.Text.ToString();
        }
        public void NavigateToAddress()
        {
            addressPageLink.Click();
        }
    }
}
