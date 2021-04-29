using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace StuartTest.Setup
{
    public abstract class BaseTest
    {
        // Selenium driver

        protected IWebDriver Driver;

        // Setup: Nunit annotation to execute a method before each test
        // Method to start the Chrome browser and navigate to a URL
        [SetUp]
        public void BeforeBaseTest()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Navigate().GoToUrl("https://dashboard.sandbox.stuart.com/log-in");
        }

        // TearDown: Nunit annotation to execute a method after each Test
        // Method to close the browser
        [TearDown]
        public void AfterBaseTest()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }


    }
}
