using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using StuartTest.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StuartTest.Setup
{
    /*
     *Clase para todas las page
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

        //Metodo para escribir el usuario
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

        //Generic function to click and wait
        protected void clickwaitElement(By Localizator)
        {
            //Actions actions = new Actions(Driver);
            //actions.MoveToElement(Driver.FindElement(TimeToDelivery.Now)).Perform();
            //Driver.FindElement(TimeToDelivery.Now).SendKeys(Keys.PageDown);
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


        protected string getText(By Localizator)
        {
            string text;
            waitElement(Localizator);
            text = Driver.FindElement(Localizator).Text;
            return text;


        }


    }

}
