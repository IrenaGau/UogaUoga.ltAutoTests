using NUnit.Framework;

namespace UogaUoga.ltAutoTests.Test
{
    public class UogaUogaTest : BaseTest
    {
        [Test]
        public static void TestSignInSignOut()
        {
            _HomePage.ProfileIconClick();
            _HomePage.InputFieldEmailSubmit();
            _HomePage.InputFieldPasswordSubmit();
            _HomePage.SignOut();
            _HomePage.VerifySignOut();
        }

        [Test]
        public static void SearchByTextTest()
        {
            _HomePage.SearchByText();
            _HomePage.ClickOnSearchIcon();
            _SearchResultPage.ClickOnKidsShampoo();
            _SearchResultPage.VerifyShampooName();
        }

        [Test]
        public static void CartTest()
        {
            _HomePage.SearchByText2();
            _HomePage.ClickOnSearchIcon();
            _SearchResultPage.ClickAddToCartMascara();
            _SearchResultPage.ClickOnCartButton();
            _CartPage.ClickOnIconPlusButton();
            _CartPage.VerifyTotalSum();
        }

        [Test]
        public static void LocationTest()
        {
            _HomePage.ClickOnLocationButton();
            _HomePage.ClickOnCityButton();
            _HomePage.VerifyTextResult();
        }

        [Test]
        public static void NewsTest()
        {
            _CatalogPage.ClickOnNewsButton();
            _CatalogPage.SelectVeganOption();
            _CatalogPage.SortByPrice();
            _CatalogPage.VerifySortResult();
        }
    }
}