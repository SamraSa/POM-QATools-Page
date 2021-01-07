using OpenQA.Selenium;

namespace ToolsQA.Pages
{
    public class HomePage
    {
        IWebDriver driver;
        By login_button = By.Id("login");
        
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickLoginButton()
        {
            driver.FindElement(login_button).Click();
        }
    }
    
}


