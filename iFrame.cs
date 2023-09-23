using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace iFRAME
{
    public class iFrame
    {
        public static void Main(string[] args)
        { 
            iFrame iframe = new iFrame();
            iframe.IframeClick();
            IWebDriver driver = new ChromeDriver();
        }

        [Test]
        public void IframeClick()
        {

            IWebDriver driver = new ChromeDriver("C:\\Users\\44751\\source\\repos\\iFRAME\\Driver\\chromedriver.exe");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://vimeo.com/blog/category/video-for-business/live-streaming");

            IWebElement iframe = driver.FindElement(By.Id("rufous-sandbox"));


            driver.SwitchTo().DefaultContent();

            IWebElement linkelement = driver.FindElement(By.PartialLinkText("All"));
            linkelement.Click();

            Thread.Sleep(3000);

            driver.Quit();


        }
    }
}
