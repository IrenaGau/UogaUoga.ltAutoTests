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
        

        private const string text = "šampūnas vaikams";
        private const string text2 = "tušas";

        private IWebElement SearchField => Driver.FindElement(By.CssSelector("#quick_search_show > i"));
        private IWebElement SearchIcon => Driver.FindElement(By.CssSelector("#quick_search > form > div > span > button > i"));
        private IWebElement InputField => Driver.FindElement(By.CssSelector("#quick_search > form > div > input"));
        private IWebElement AddToCartShampoo => Driver.FindElement(By.CssSelector("#accordion > div.product_items > div > div > a > span.btn.btn-default.add2cart"));
        private IWebElement AddToCartMascara => Driver.FindElement(By.CssSelector("#accordion > div.product_items > div > div > a > span.btn.btn-default.add2cart"));

        public void SearchByText()
        {
            GetWait().Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ajax_loader")));
            SearchField.Click();
            InputField.Clear();
            InputField.SendKeys(text);
        }


    }



    



}
