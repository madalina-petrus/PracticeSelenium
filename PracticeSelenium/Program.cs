using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public static class Selenium
    {
        public static void homepage()
        {
            IWebDriver WebDriver = new ChromeDriver("D://internship//PracticeSelenium//PracticeSelenium//driver");
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
        }

        public static void account()
        {
            IWebDriver WebDriver = new ChromeDriver("D://internship//PracticeSelenium//PracticeSelenium//driver");
            WebDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com");
            IWebElement account = WebDriver.FindElement(By.CssSelector(".account-cart-wrapper"));
            Console.WriteLine("Account:" + account);
            account.Click();
            //WebDriver.Quit();


        }

        public static void languages ()
        {
            IWebDriver WebDriver = new ChromeDriver("D://internship//PracticeSelenium//PracticeSelenium//driver");
            WebDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com");
            IWebElement language = WebDriver.FindElement(By.CssSelector("#select-language"));
            
            SelectElement select = new SelectElement(language);
            Console.WriteLine("Number of languages: "+ select.Options.Count);
            select.SelectByIndex(1);
            WebDriver.Quit();
        }

        public static void search()
        {
            IWebDriver WebDriver = new ChromeDriver("D://internship//PracticeSelenium//PracticeSelenium//driver");
            WebDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com");
            IWebElement search = WebDriver.FindElement(By.CssSelector("#search"));
            search.Clear();
            search.SendKeys("woman");
            search.Submit();
            WebDriver.Quit();
        }

        public static void newProductList()
        {
            IWebDriver WebDriver = new ChromeDriver("D://internship//PracticeSelenium//PracticeSelenium//driver");
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");
            IList<IWebElement> newProductList= WebDriver.FindElements(By.CssSelector(".widget-new-products .products-grid .item"));
            Console.WriteLine("Number of new products: " + newProductList.Count());
            foreach(var i in newProductList)
                Console.WriteLine(i);
            WebDriver.Quit();
        }


        public static void navigation(string name)
        {
            IWebDriver WebDriver = new ChromeDriver("D://internship//PracticeSelenium//PracticeSelenium//driver");
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");
            IList<IWebElement> headline = WebDriver.FindElements(By.CssSelector(".nav-primary"));
            Console.WriteLine("Number of categorys: " + headline.Count());
            foreach (var i in headline)
                Console.WriteLine(i.Text);

            foreach (var i in headline)
                if (i.Text.Equals(name))
                {
                    i.Click();
                    break;
                }
           // WebDriver.Quit();

        }

        public static void addToCart()
        {
            IWebDriver WebDriver = new ChromeDriver("D://internship//PracticeSelenium//PracticeSelenium//driver");
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");
            //IWebElement page = WebDriver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-4.active.parent > ul > li.level1.nav-4-1.first.active > a"));
            //page.Click();
            //page = WebDriver.FindElement(By.CssSelector("body > div > div > div.main - container.col2 - right - layout > div > div.col - main > div.category - products > ul > li:nth - child(3) > a"));
            //page.Click();

            IWebElement ele = WebDriver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-3.active.parent > a"));
            ele.Click();
            //Actions action = new Actions(WebDriver);
            //action.MoveToElement(ele).Perform();
            IWebElement page = WebDriver.FindElement(By.CssSelector("#body > div > div > div.main-container.col1-layout > div > div.col-main > ul > li:nth-child(1) > a"));
            page.Click();


        }

        public static void Main(string[] args)
        {

            //homepage();
            //account();
            //languages();
            //search();
            //newProductList();
            navigation("MEN");
            //addToCart();

        }
    }
}

