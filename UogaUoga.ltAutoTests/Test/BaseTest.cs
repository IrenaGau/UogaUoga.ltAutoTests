using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UogaUoga.ltAutoTests.Page;

namespace UogaUoga.ltAutoTests.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static UogaHomePage _HomePage;
        public static UogaCartPage _CartPage;
        public static UogaSearchResultPage _SearchResultPage;
        public static CatalogPage _CatalogPage;

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
            _CatalogPage = new CatalogPage(driver);
            _HomePage.NavigateToPage();
            _HomePage.ClosePopUp();
            _HomePage.AcceptCookies();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _HomePage.CloseBrowser();
        }
    }
}
