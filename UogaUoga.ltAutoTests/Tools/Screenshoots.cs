using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UogaUoga.ltAutoTests.Tools
{
    public class Screenshoots
    {
        public static void TakeScreenshot(IWebDriver webdriver)
        {
            Screenshot screenshot = webdriver.TakeScreenshot();
            string myScreenshotDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
            string myScreenshotFolder = Path.Combine(myScreenshotDir, "screenshots");
            Directory.CreateDirectory(myScreenshotFolder);
            string screenshotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH_mm}.png";
            string screenshotPath = Path.Combine(myScreenshotFolder, screenshotName);
            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
        }
    }
}
