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
            page = new UogaUogaPage(driver);
        }

        //[OneTimeTearDown]
        //public static void OneTimeTearDown()
        //{
        //    page.CloseBrowser();
        //}

        [Test]
        public static void TestSignIn()
        {
            page.NavigateToPage();
            page.ClosePopUp();
            page.CloseCookies();
            page.ProfileIconClick();
            page.InputFieldEmailSubmit();
            page.InputFieldPasswordSubmit();
        }

        [Test]
        public static void AddToCartBySearch()
        {
            page.NavigateToPage();
            page.ClosePopUp();
            page.CloseCookies();
            page.SearchByText();
            page.ClickOnSearchIcon();
            page.ClickAddToCart();

            //}

            //[Test]
            //public static void Test3()
            //{

            //}

            //[Test]
            //public static void Test4()
            //{

            //}

            //[Test]
            //public static void Test5()
            //{

            //}
        }
    }
}