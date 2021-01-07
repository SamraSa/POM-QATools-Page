using OpenQA.Selenium;
using System;
using System.Threading;
using ToolsQA.Pages;

namespace ToolsQA.TestCases
{
    public class ValidLogin
    {

        public static void Main()
        {
            TestBase testBase = new TestBase();
            
            IWebDriver driver = testBase.Init();

            HomePage homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            DashboardPage dashboard = new DashboardPage(driver);

    
            homePage.ClickLoginButton();
            Thread.Sleep(5000);

            loginPage.TypeUsername("Samra");
            loginPage.TypePassword("Samra123!");
            Thread.Sleep(5000);
            
            loginPage.ClickLoginButton();
            Thread.Sleep(5000);

            Console.WriteLine("The page heading is " + dashboard.getHeading());
            dashboard.clickLogout();
            Thread.Sleep(5000);

            testBase.CloseBrowser(driver);

        }

    }
}
