using OpenQA.Selenium;
using StuartTest.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StuartTest.PageObject
{
    class OnGoingPage : BasePage
    {
        //Localizators
        protected By OnGoingTitle = By.XPath("//title[contains(text(),'Stuart')]");

        //protected By LoginTitle = By.Id("Stuart");

        //Builder throws an exception if the title of the page is not correct
        public OnGoingPage(IWebDriver driver)
        {
            Driver = driver;
            Thread.Sleep(500);
            waitElement(OnGoingTitle);
            if (!Driver.Title.Equals("Ongoing (2) | Stuart"))
                throw new Exception("This ir not a Login page");
        }
    }
}
