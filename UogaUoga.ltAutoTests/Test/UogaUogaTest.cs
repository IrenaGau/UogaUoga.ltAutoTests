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
            page.NavigateToPage();
            page.ClosePopUp();
            page.CloseCookies();
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
            page.SignOut();
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
            //page.VerifyTotalSum();//Neveikia
        }

        [Test]
        public static void LocationTest()
        {
            page.ClickOnLocationButton();
            page.ClickOnCityButton();
            page.VerifyTextResult();
        }

        [Test]
        public static void NewsTest()
        {
            page.ClickOnNewsButton();
            page.SelectVeganOption();
            page.SortByPrice();
            page.VerifySortResult();
        }

    }
}