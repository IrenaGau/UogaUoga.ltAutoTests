using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using System.Threading;
using System.Linq;

namespace UogaUoga.ltAutoTests.Page
{
    public class UogaHomePage : BasePage
    {
        private const string PageAddress = "https://uogauoga.lt/";
        private const string email = "naudotojas@yahoo.com";
        private const string password = "uoga";
        private const string text = "šampūnas vaikams";
        private const string text2 = "tušas";
        public UogaHomePage(IWebDriver webdriver) : base(webdriver) { }

        private IWebElement PopUp => Driver.FindElement(By.CssSelector("#comProjectPopup > div > div:nth-child(2) > a"));
        private IWebElement Cookies => Driver.FindElement(By.CssSelector("#type_index > div.cookie_bar.clearfix > div > p > span"));
        private IWebElement ProfileIcon => Driver.FindElement(By.CssSelector("#profile_menu > a > i"));
        private IWebElement InputFieldemail => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(2) > input"));
        private IWebElement InputFieldpassword => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(3) > input"));
        private IWebElement EmailSubmitButton => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(3) > button"));
        private IWebElement PasswordSubmitButton => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(4) > button"));
        private IWebElement ProfileMenuSignOut => Driver.FindElement(By.CssSelector("#profile_menu > ul > li:nth-child(3) > a"));
        private IWebElement SearchField => Driver.FindElement(By.CssSelector("#quick_search_show > i"));
        private IWebElement SearchIcon => Driver.FindElement(By.CssSelector("#quick_search > form > div > span > button > i"));
        private IWebElement InputField => Driver.FindElement(By.CssSelector("#quick_search > form > div > input"));
        private IWebElement LocationButton => Driver.FindElement(By.CssSelector("#headerLocationLink > a > i"));
        private IWebElement CityButton => Driver.FindElement(By.CssSelector("#departments_listing > div.filters > div > div > ul > li:nth-child(10) > a"));
        private IWebElement ResultElement => Driver.FindElement(By.CssSelector("#departments_listing > div.container-fluid > div > div > span > span.name"));
        private IWebElement ResultElementSecond => Driver.FindElement(By.CssSelector("#departments_listing > div.container-fluid > div > div > span > span:nth-child(2)"));


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

        public void AcceptCookies()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#type_index > div.cookie_bar.clearfix > div > p > span")));
            Cookies.Click();
        }

        public void ProfileIconClick()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            ProfileIcon.Click();
        }


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

        public void SignOut()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("item")));
            ProfileIcon.Click();
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#profile_menu > ul")));
            ProfileMenuSignOut.Click();
        }

        public void SearchByText()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            SearchField.Click();
            InputField.Clear();
            InputField.SendKeys(text);
        }

        public void SearchByText2()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            SearchField.Click();
            InputField.Clear();
            InputField.SendKeys(text2);
        }

        public void ClickOnSearchIcon()
        {
            SearchIcon.Click();
        }

        public void ClickOnLocationButton()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            LocationButton.Click();
        }
        public void ClickOnCityButton()
        {
            CityButton.Click();
        }

        public void VerifyTextResult()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("#departments_listing > div.container-fluid > div > div > span")));
            Assert.AreEqual("RIMI Utena, \"Uoga Uoga\" produkcijos lentynos", ResultElement.Text, $"Text is not the same, actual text is {ResultElement.Text}");
            Assert.AreEqual("Basanavičiaus g. 52, Utena", ResultElementSecond.Text, $"Text is not the same, actual text is {ResultElementSecond.Text}");
        }

    }
}
