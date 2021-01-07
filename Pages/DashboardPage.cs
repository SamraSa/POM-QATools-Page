using OpenQA.Selenium;
using System;

namespace ToolsQA.Pages
{
    public class DashboardPage
    {
        IWebDriver driver;
        By heading = By.CssSelector("#app > div > div > div.pattern-backgound.playgound-header > div");
        By logout_button = By.Id("submit");

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }
 

        public String getHeading()
        {
            string head = driver.FindElement(heading).Text;
            return head;
        }
        public void clickLogout()
        {
            driver.FindElement(logout_button).Click();
        }

    }

}


