using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace UogaUoga.ltAutoTests.Page
{
    public class UogaSearchResultPage : BasePage
    {
        public UogaSearchResultPage(IWebDriver webdriver) : base(webdriver) { }
        private IWebElement Kidshampoo => Driver.FindElement(By.CssSelector("#accordion > div.product_items > div > div > a > span.img-wrapper > span > picture > img"));
        private IWebElement KidshampooName => Driver.FindElement(By.CssSelector("#products_detailed > div.product_block > div > div > div.col-md-6.col-xs-12.summary_wrp > h1"));
        private IWebElement AddToCartMascara => Driver.FindElement(By.CssSelector("#accordion > div.product_items > div > div > a > span.btn.btn-default.add2cart"));
        private IWebElement CartButton => Driver.FindElement(By.CssSelector("#cart_info > a > em"));

        public void ClickOnKidsShampoo()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            Kidshampoo.Click();
        }

        public void VerifyShampooName()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            Assert.AreEqual("VĖŽLIUKAS KOKO", KidshampooName.Text, $"Text is not the same, actual text is {KidshampooName.Text}");
        }

        public void ClickAddToCartMascara()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            AddToCartMascara.Click();
        }

        public void ClickOnCartButton()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            CartButton.Click();
        }
    }
}
