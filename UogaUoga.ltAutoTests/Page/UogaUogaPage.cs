using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using System.Threading;

namespace UogaUoga.ltAutoTests.Page
{
    public class UogaUogaPage : BasePage
    {
        private const string PageAddress = "https://uogauoga.lt/";
        private const string email = "naudotojas@yahoo.com";
        private const string password = "uoga";
        private const string text = "šampūnas";
        private const string text2 = "kremas";

        private SelectElement DropdownSort => new SelectElement(Driver.FindElement(By.Id("filter-dropdown-sort_by")));
        
        private IWebElement PopUp => Driver.FindElement(By.CssSelector("#comProjectPopup > div > div:nth-child(2) > a"));
        private IWebElement Cookies => Driver.FindElement(By.CssSelector("#type_index > div.cookie_bar.clearfix > div > p > span"));
        private IWebElement ProfileIcon => Driver.FindElement(By.CssSelector("#profile_menu > a > i"));
        private IWebElement InputFieldemail => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(2) > input"));
        private IWebElement InputFieldpassword => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(3) > input"));
        private IWebElement EmailSubmitButton => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(3) > button"));
        private IWebElement PasswordSubmitButton => Driver.FindElement(By.CssSelector("#login_form > div:nth-child(4) > button"));
        private IWebElement ProfileMenu => Driver.FindElement(By.CssSelector("#profile_menu > ul"));
        private IWebElement ProfileMenuSignOut => Driver.FindElement(By.CssSelector("#profile_menu > ul > li:nth-child(3) > a"));
        private IWebElement SearchField => Driver.FindElement(By.CssSelector("#quick_search_show > i"));
        private IWebElement SearchIcon => Driver.FindElement(By.CssSelector("#quick_search > form > div > span > button > i"));
        private IWebElement InputField => Driver.FindElement(By.CssSelector("#quick_search > form > div > input"));
        private IWebElement AddToCart => Driver.FindElement(By.CssSelector("#accordion > div.product_items > div > div:nth-child(2) > a > span.btn.btn-default.add2cart"));
        private IWebElement CartButton => Driver.FindElement(By.CssSelector("#cart_info > a > em"));
        private IWebElement IconPlusButton => Driver.FindElement(By.CssSelector("#cart_items > table > tbody > tr > td.amount.hidden-xs > form > div > div > span:nth-child(3) > button > span"));
        private IWebElement TotalSum => Driver.FindElement(By.XPath("//div[text()='Bendra suma:']//following::div[1]"));
        private IWebElement LocationButton => Driver.FindElement(By.CssSelector("#headerLocationLink > a > i"));
        private IWebElement CityButton => Driver.FindElement(By.CssSelector("#departments_listing > div.filters > div > div > ul > li:nth-child(10) > a"));
        private IWebElement ResultElement => Driver.FindElement(By.CssSelector("#departments_listing > div.container-fluid > div > div > span > span.name"));
        private IWebElement ResultElementSecond => Driver.FindElement(By.CssSelector("#departments_listing > div.container-fluid > div > div > span > span:nth-child(2)"));
        private IWebElement NewsButton => Driver.FindElement(By.CssSelector("#mega_menu > li:nth-child(1) > a > h4"));
        private IWebElement SelectVegan => Driver.FindElement(By.CssSelector("#filter_fmodcheck_6 > h5 > span"));
        private IWebElement SortByButton => Driver.FindElement(By.CssSelector("#filter-dropdown-sort_by"));
        private IWebElement SortByPriceOption => Driver.FindElement(By.CssSelector("#filter_block > div > div.filter-group.sort_block > div.dropdown.hidden-xs.hidden-sm.open > div > ul > li:nth-child(2)"));
        private IWebElement SortResultElement => Driver.FindElement(By.CssSelector("#products_column > div.product_listing > div > div:nth-child(1) > a > span.title > span.product_name"));
        private IWebElement SortResultElement2 => Driver.FindElement(By.CssSelector("#products_column > div.product_listing > div > div:nth-child(2) > a > span.title > span.product_name"));
       
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

        public void ClickAddToCart()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            AddToCart.Click();
        }

        public void ClickOnCartButton()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            CartButton.Click();
        }

        public void ClickOnIconPlusButton()
        {
            IconPlusButton.Click();
        }

        public void VerifyTotalSum()
        {
            //GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[text()='Bendra suma:']//following::div[1]")));
            Thread.Sleep(5000);
            Assert.IsTrue("43,90 €".Equals(TotalSum.Text), $"Text is not the same, actual text is {TotalSum.Text}");
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
            Assert.AreEqual("RIMI Utena, \"Uoga Uoga\" produkcijos lentynos",ResultElement.Text, $"Text is not the same, actual text is {ResultElement.Text}");
            Assert.AreEqual("Basanavičiaus g. 52, Utena", ResultElementSecond.Text, $"Text is not the same, actual text is {ResultElementSecond.Text}");
        }

        public void ClickOnNewsButton()
        {
            NewsButton.Click();
        }

        public void SelectVeganOption()
        {
            SelectVegan.Click();
        }

        public void SortByPrice()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            SortByButton.Click();
            SortByPriceOption.Click();
        }

        public void VerifySortResult()
        {
            Assert.AreEqual("BLAKSTIENŲ DRAMA", SortResultElement.Text, $"Text is not the same, actual text is {SortResultElement.Text}");
            Assert.AreEqual("PAMILK IŠ NAUJO", SortResultElement2.Text, $"Text is not the same, actual text is {SortResultElement2.Text}");
        }

    }
}

