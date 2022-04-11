using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UogaUoga.ltAutoTests.Page
{
    public class CatalogPage : BasePage
    {
        public CatalogPage(IWebDriver webdriver) : base(webdriver) { }
        private IWebElement NewsButton => Driver.FindElement(By.CssSelector("#mega_menu > li:nth-child(1) > a > h4"));
        private IWebElement SelectVegan => Driver.FindElement(By.CssSelector("#filter_fmodcheck_6 > h5 > span"));
        private IWebElement SortByButton => Driver.FindElement(By.CssSelector("#filter-dropdown-sort_by"));
        private IWebElement SortByPriceOption => Driver.FindElement(By.CssSelector("#filter_block > div > div.filter-group.sort_block > div.dropdown.hidden-xs.hidden-sm.open > div > ul > li:nth-child(2)"));
        private IWebElement SortResultElement => Driver.FindElement(By.CssSelector("#products_column > div.product_listing > div > div:nth-child(1) > a > span.title > span.product_name"));
        private IWebElement SortResultElement2 => Driver.FindElement(By.CssSelector("#products_column > div.product_listing > div > div:nth-child(2) > a > span.title > span.product_name"));
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
            Assert.AreEqual("DVIPUSIS ŠEPETĖLIS AKIŲ ŠEŠĖLIAMS", SortResultElement2.Text, $"Text is not the same, actual text is {SortResultElement2.Text}");
        }
    }
}
