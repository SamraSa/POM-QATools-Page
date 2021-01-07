using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace ToolsQA.Pages
{
    public class LoginPage
    {
       
        IWebDriver driver;
        By Username = By.Id("userName");
        By Password = By.Id("password");
        By login_button = By.Id("login");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUsername(string user)
        {
            driver.FindElement(Username).SendKeys(user);
        }

        public void TypePassword(string pass)
        {
            driver.FindElement(Password).SendKeys(pass);
        }

        public void ClickLoginButton()
        {

            //scroll element into view

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(login_button));
            action.Build().Perform();
            driver.FindElement(login_button).Click();
          

        }
    }
}
