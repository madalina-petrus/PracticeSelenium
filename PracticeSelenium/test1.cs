using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PracticeSelenium
{
    [TestFixture]
    public class test1
    {
        IWebDriver WebDriver;
        [SetUp]
        public void start()
        {
            WebDriver = new ChromeDriver("D://internship//PracticeSelenium//PracticeSelenium//driver");

        }

        [Test]
        public void homepage()
        {
            WebDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com");

            IWebElement title = WebDriver.FindElement(By.CssSelector("head > title"));
            Console.WriteLine("Titlu:   " + title);

            string title2 = WebDriver.Title;
            Console.WriteLine("Titlu2:  " + title2);

            string url = WebDriver.Url;
            Console.WriteLine("URL:  " + url);

            IWebElement logo = WebDriver.FindElement(By.CssSelector(".logo"));
            Console.WriteLine("Logo:" + logo);
            logo.Click();
            //for(int i=1;i<=1000;i++)
            //{
            //  logo.Click();
            //logo = WebDriver.FindElement(By.CssSelector("#header > div > a > img.large")); 
            //}

            IWebElement page = WebDriver.FindElement(By.CssSelector(".nav-primary li.level0"));
            Console.WriteLine("Page:" + page);
            page.Click();
            WebDriver.Navigate().Back();
            WebDriver.Navigate().Forward();
            WebDriver.Navigate().Refresh();
            WebDriver.Quit();

            Assert.That(WebDriver.Url, Is.EqualTo("http://qa2magento.dev.evozon.com/women.html"));
        }
    }
}
