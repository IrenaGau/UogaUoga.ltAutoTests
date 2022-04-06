using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace UogaUoga.ltAutoTests.Page
{
    public class UogaUogaPage : BasePage
    {
        private const string PageAddress = "https://uogauoga.lt/";
        private const string email = "naudotojas@yahoo.com";
        private const string password = "uoga";
        private const string text = "šampūnas";
        private const string text2 = "kremas";
        private object resultElement;

        private IWebElement PopUp => Driver.FindElement(By.CssSelector("#comProjectPopup > div > div:nth-child(2) > a"));
        private IWebElement Cookies => Driver.FindElement(By.CssSelector("#type_index > div.cookie_bar.clearfix > div > p > span"));
        private IWebElement ProfileIcon => Driver.FindElement(By.CssSelector("#profile_menu > a > i"));
        private IWebElement InputFieldemail => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(2) > input"));
        private IWebElement InputFieldpassword => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(3) > input"));
        private IWebElement EmailSubmitButton => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(3) > button"));
        private IWebElement PasswordSubmitButton => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(4) > button"));
        private IWebElement SearchField => Driver.FindElement(By.CssSelector("#quick_search_show > i"));
        private IWebElement SearchIcon => Driver.FindElement(By.CssSelector("#quick_search > form > div > span > button > i"));
        private IWebElement InputField => Driver.FindElement(By.CssSelector("#quick_search > form > div > input"));
        private IWebElement AddToCart => Driver.FindElement(By.CssSelector("#accordion > div.product_items > div > div:nth-child(2) > a > span.btn.btn-default.add2cart"));
        private IWebElement CartButton => Driver.FindElement(By.CssSelector("#cart_info > a > em"));
        private IWebElement IconPlusButton => Driver.FindElement(By.CssSelector("#cart_items > table > tbody > tr > td.amount.hidden-xs > form > div > div > span:nth-child(3) > button > span"));
        private IWebElement LocationButton => Driver.FindElement(By.CssSelector("#headerLocationLink > a > i"));
        private IWebElement CityButton => Driver.FindElement(By.CssSelector("#departments_listing > div.filters > div > div > ul > li:nth-child(6) > a"));
        private IWebElement ResultElement => Driver.FindElement(By.CssSelector("#departments_listing > div.container-fluid > div > div > span"));
        private IWebElement IncreaseQuantity => Driver.FindElement(By.CssSelector("#cart_items > table > tbody > tr > td.amount.hidden-xs > form > div > div > span:nth-child(3) > button > span"));
        public UogaUogaPage(IWebDriver webdriver) : base(webdriver) { }

        //public void NavigateToPage()
        //{
        //    if (Driver.Url != PageAddress)
        //        Driver.Url = PageAddress;
        //}

        //public void ClosePopUp()
        //{
        //    GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#comProjectPopup > div > div:nth-child(2) > a")));
        //    PopUp.Click();
        //}

        //public void CloseCookies()
        //{
        //    GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#type_index > div.cookie_bar.clearfix > div > p > span")));
        //    Cookies.Click();
        //}

        public void ProfileIconClick()
        {
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

        public void SearchByText()
        {
            SearchField.Click();
            InputField.Clear();
            InputField.SendKeys(text);
        }

        public void SearchByText2()
        {
            SearchField.Click();
            InputField.Clear();
            InputField.SendKeys(text2);
        }

        public void ClickOnSearchIcon()
        {
            SearchIcon.Click();
        }

        public void ClickAddToCart()
        {
            AddToCart.Click();
        }

        public void ClickOnCartButton()
        {
            GetWait().Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#cart_info > a > em")));
            CartButton.Click();
        }

        public void ClickOnIconPlusButton()
        {
            IconPlusButton.Click();
        }

        public void ClickOnLocationButton()
        {
            LocationButton.Click();
        }
        public void ClickOnCityButton()
        {
            CityButton.Click();
        }

        public void VerifyTextResult()
        {
            Assert.IsTrue("PC Palanga RIMI Hypermarket, Uoga Uoga produkcijos lentynos Malūno g. 10, Palanga".Equals(ResultElement.Text), $"Text is not the same, actual text is {ResultElement.Text}");
        }

        public void InsertQuantity()
        {
            for (int i = 1; i < 5; i++)
            {
                IncreaseQuantity.Click();

            }
        }
    }
}
