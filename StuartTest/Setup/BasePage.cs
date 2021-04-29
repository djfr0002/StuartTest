using OpenQA.Selenium;
using StuartTest.Handler;
using System.Threading;


namespace StuartTest.Setup
{
    /*
     *Class for all pages
     */
    public abstract class BasePage
    {
        // Selenium driver

        protected IWebDriver Driver;

        //
        protected void waitElement(By Localizator)
        {
            WaitHandler.ElementIsPresent(Driver, Localizator);
            
        }

        //Generic Method to write in a box
        protected void Type(By Localizator, string text)
        {
            waitElement(Localizator);
            Driver.FindElement(Localizator).SendKeys(text);
        }

        //Generic function to click

        protected void clickElement(By Localizator)
        {
            waitElement(Localizator);
            Driver.FindElement(Localizator).Click();           
        }

        ////Generic function to click and wait
        protected void clickwaitElement(By Localizator)
        {
            Thread.Sleep(2000);
            Driver.FindElement(Localizator).SendKeys(Keys.PageDown);
            Thread.Sleep(2000);
            waitElement(Localizator);
            Driver.FindElement(Localizator).Click();
        }

        //Select Item from to List
        public void SelectItem(By Localizator, By Scenario)
        {
            clickElement(Localizator);
            Thread.Sleep(1000);
            clickElement(Scenario);
        }

        //Method to get text
        protected string getText(By Localizator)
        {
            string text;
            waitElement(Localizator);
            text = Driver.FindElement(Localizator).Text;
            return text;
        }


    }

}
