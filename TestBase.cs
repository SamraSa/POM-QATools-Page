using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ToolsQA.TestCases
{
    public class TestBase
    {


        public IWebDriver Init()
        {
            string url = "https://www.demoqa.com/books";


            //Here we create an object of WebDriver, launching URL, maximize browserlaunching URL 

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            return driver;

        }


        public void CloseBrowser(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}
