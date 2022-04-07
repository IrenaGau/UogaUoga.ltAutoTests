using System;
using UogaUoga.ltAutoTests.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UogaUoga.ltAutoTests.Test
{
    public class UogaUogaTest
    {
        private static IWebDriver driver;
        private static UogaUogaPage page;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://uogauoga.lt/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("#comProjectPopup > div > div:nth-child(2) > a")).Click();
            driver.FindElement(By.CssSelector("#type_index > div.cookie_bar.clearfix > div > p > span")).Click();
            page = new UogaUogaPage(driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            page.CloseBrowser();
        }

        [Test]
        public static void TestSignInSignOut()
        {
            page.ProfileIconClick();
            page.InputFieldEmailSubmit();
            page.InputFieldPasswordSubmit();
            //page.ProfileIconClick();
            //page.SelectFromDropdownByIndex(2);

            //page.LogOut();//??
        }

        [Test]
        public static void AddToCartBySearch()
        {
            page.SearchByText();
            page.ClickOnSearchIcon();
            page.ClickAddToCart();

        }

        [Test]
        public static void CartTest()
        {
            page.SearchByText2();
            page.ClickOnSearchIcon();
            page.ClickAddToCart();
            page.ClickOnCartButton();
            page.ClickOnIconPlusButton();


        }

        [Test]
        public static void LocationTest()
        {
            page.ClickOnLocationButton();
            page.ClickOnCityButton();
            //page.VerifyTextResult();
        }

    }
}