using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UogaUoga.ltAutoTests.Page
{
    public class UogaSearchResultPage : BasePage
    {
        public UogaSearchResultPage(IWebDriver webdriver) : base(webdriver) { }
        private IWebElement AddToCartShampoo => Driver.FindElement(By.CssSelector("#accordion > div.product_items > div > div > a > span.btn.btn-default.add2cart"));
        private IWebElement AddToCartMascara => Driver.FindElement(By.CssSelector("#accordion > div.product_items > div > div > a > span.btn.btn-default.add2cart"));
        private IWebElement CartButton => Driver.FindElement(By.CssSelector("#cart_info > a > em"));

        public void ClickAddToCartShampoo()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            AddToCartShampoo.Click();
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
