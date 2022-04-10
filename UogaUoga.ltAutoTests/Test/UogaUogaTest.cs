using System;
using UogaUoga.ltAutoTests.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UogaUoga.ltAutoTests.Test
{
    public class UogaUogaTest
    {
        public static IWebDriver driver;
        public static UogaHomePage HomePage;
        public static UogaCartPage CartPage;
        public static UogaSearchResultPage SearchResultPage;
        public static CatalogPage CatalogPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://uogauoga.lt/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            HomePage = new UogaHomePage(driver);
            CartPage = new UogaCartPage(driver);
            SearchResultPage = new UogaSearchResultPage(driver);
            CatalogPage = new CatalogPage(driver);
            HomePage.NavigateToPage();
            HomePage.ClosePopUp();
            HomePage.AcceptCookies();

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            HomePage.CloseBrowser();
        }

        [Test]
        public static void TestSignInSignOut()
        {
            HomePage.ProfileIconClick();
            HomePage.InputFieldEmailSubmit();
            HomePage.InputFieldPasswordSubmit();
            HomePage.SignOut();
        }

        [Test]
        public static void AddToCartBySearch()
        {
            HomePage.SearchByText();
            HomePage.ClickOnSearchIcon();
            SearchResultPage.ClickAddToCartShampoo();

        }

        [Test]
        public static void CartTest()
        {
            HomePage.SearchByText2();
            HomePage.ClickOnSearchIcon();
            SearchResultPage.ClickAddToCartMascara();
            CartPage.ClickOnCartButton();
            CartPage.ClickOnIconPlusButton();
            CartPage.VerifyTotalSum();
        }

        [Test]
        public static void LocationTest()
        {
            HomePage.ClickOnLocationButton();
            HomePage.ClickOnCityButton();
            HomePage.VerifyTextResult();
        }

        [Test]
        public static void NewsTest()
        {
            CatalogPage.ClickOnNewsButton();
            CatalogPage.SelectVeganOption();
            CatalogPage.SortByPrice();
            CatalogPage.VerifySortResult();
        }

    }
}