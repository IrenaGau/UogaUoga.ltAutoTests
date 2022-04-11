using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using UogaUoga.ltAutoTests.Page;
using UogaUoga.ltAutoTests.Tools;

namespace UogaUoga.ltAutoTests.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static UogaHomePage _HomePage;
        public static UogaCartPage _CartPage;
        public static UogaSearchResultPage _SearchResultPage;
        public static UogaCatalogPage _CatalogPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://uogauoga.lt/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _HomePage = new UogaHomePage(driver);
            _CartPage = new UogaCartPage(driver);
            _SearchResultPage = new UogaSearchResultPage(driver);
            _CatalogPage = new UogaCatalogPage(driver);
            _HomePage.NavigateToPage();
            _HomePage.ClosePopUp();
            _HomePage.AcceptCookies();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(driver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _HomePage.CloseBrowser();
        }
    }
}
