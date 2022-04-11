using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UogaUoga.ltAutoTests.Page
{
    public class UogaCartPage : BasePage
    {
        public UogaCartPage(IWebDriver webdriver) : base(webdriver) { }
        private IWebElement IconPlusButton => Driver.FindElement(By.CssSelector("#cart_items > table > tbody > tr > td.amount.hidden-xs > form > div > div > span:nth-child(3) > button > span"));
        private IReadOnlyCollection<IWebElement> TotalSums => Driver.FindElements(By.XPath("//div[text()='Bendra suma:']//following::div[1]"));

        public void ClickOnIconPlusButton()
        {
            IconPlusButton.Click();
        }

        public void VerifyTotalSum()
        {
           Thread.Sleep(4000);
           Assert.IsTrue("39,90 €".Equals(TotalSums.ElementAt(1).Text), $"Text is not the same, actual text is {TotalSums.ElementAt(1).Text}");
        }
    }
}
