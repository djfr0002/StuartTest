using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace StuartTest.Handler
{
    //Class for explicit waits
    public class WaitHandler
    {
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch
            {
                return false;
            }
            

        }
    }
}
