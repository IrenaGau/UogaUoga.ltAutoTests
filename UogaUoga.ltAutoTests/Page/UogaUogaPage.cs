using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace UogaUoga.ltAutoTests.Page
{
    public class UogaUogaPage : BasePage
    {
        private const string PageAddress = "https://uogauoga.lt/";
        private IWebElement PopUp => Driver.FindElement(By.CssSelector("#comProjectPopup > div > div:nth-child(2) > a"));
        private IWebElement Cookies => Driver.FindElement(By.CssSelector("#type_index > div.cookie_bar.clearfix > div > p > span"));
        private IWebElement ProfileIcon => Driver.FindElement(By.CssSelector("#profile_menu > a > i"));
        private IWebElement InputFieldemail => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(2) > input"));
        private IWebElement InputFieldpassword => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(3) > input"));
        private IWebElement EmailSubmitButton => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(3) > button"));
        private IWebElement PasswordSubmitButton => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(4) > button"));

        public UogaUogaPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
        }

        public void ClosePopUp()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#comProjectPopup > div > div:nth-child(2) > a")));
            PopUp.Click();
        }

        public void CloseCookies()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#type_index > div.cookie_bar.clearfix > div > p > span")));
            Cookies.Click();
        }

        public void ProfileIconClick()
        {
           ProfileIcon.Click();
        }

        string email = "naudotojas@yahoo.com";
        string password = "uoga";
        public void InputFieldEmailSubmit()
        {
            InputFieldemail.SendKeys(email);
            EmailSubmitButton.Submit();
        }

        public void InputFieldPasswordSubmit()
        {
            InputFieldpassword.SendKeys(password);
            PasswordSubmitButton.Submit();
        }
    }
}

