using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StuartTest.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartTest.Setup
{
    public abstract class BaseTest
    {
        // Selenium driver

        protected IWebDriver Driver;

        //Setup: Anotacion de Nunit para ejecutar un metodo antes de cada test
        //Metodo para iniciar el navegador de Chrome y navegar a una URL
        [SetUp]
        public void BeforeBaseTest()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Navigate().GoToUrl("https://dashboard.sandbox.stuart.com/log-in");
        }

        ////Choose Kind of transport
        //public void ChooseTransport(By Transport)
        //{
        //    Transport = DashboardStuartPage.Transport;
        //    WaitHandler.ElementIsPresent(Driver, Transport);
        //    Driver.FindElement(Transport).Click();
        //}

        //TearDown: Anotacion Nunit para ejecutar un metodo despues de cada Test
        //Metodo para cerrar el navegador
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
