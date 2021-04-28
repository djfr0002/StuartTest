using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StuartTest.PageObject;
using StuartTest.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartTest.TestCase
{
    /*
     Clase que contiene los casos de prueba
     */
    [TestFixture]
    public class Tests : BaseTest
    {



        //Metodo de Anotacion de Nunit para marcar a un metodo como caso de prueba automatizado
        //Metodo de implementacion del caso de prueba login. Resultado esperado que el usuario se loguee correctamente.
        [Test]
        public void SuccesfulLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);

            Assert.IsTrue(dashboardStuartPage.FormIsPresent()); 
        }

        [TestCase(TestData.Wrongemail, TestData.Password)]
        public void WrongUserLoginTest(string Wrongemail, string Password)
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs(Wrongemail, Password);
            
            Assert.IsTrue(loginPage.LogIsPresent());
        }

        [Test]
        public void WrongPasswordLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs("strt.wa+test@gmail.com", "Test32234");

            Assert.IsTrue(loginPage.LogIsPresent());
        }



        //Metodo de Anotacion de Nunit para marcar a un metodo como caso de prueba automatizado
        //Metodo de implementacion del caso de prueba login. Resultado esperado que el usuario se loguee correctamente.
        [Test]

        /* Test to do a Delevery in a Motorbike*/
        public void DeliveryMotorBikeTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);
            dashboardStuartPage.StartDelivery(ChoosseScenario.RoleListScenario, ChoosseScenario.HappyPathSC);
            dashboardStuartPage.AddPickUp();
            dashboardStuartPage.AddDropOff(Adrress.SaveAddresInputBDO, "octopu ", "", "", "", "", "", " ");
            dashboardStuartPage.ChooseTransport(Transport.Motorbike);
            //dashboardStuartPage.DeliveryNow();
            dashboardStuartPage.RequestDelivery();
            //dashboardStuartPage.Check(/*"Antonio"*/);
        }

        [Test]

        /* Test to do a Delevery in a Bike*/
        public void DeliveryBikeTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);
            dashboardStuartPage.StartDelivery(ChoosseScenario.RoleListScenario, ChoosseScenario.HappyPathSC);
            dashboardStuartPage.AddPickUp(Adrress.SaveAddressInput,"La Sagrada Familia", "", "", "", "", "", "");
            dashboardStuartPage.AddDropOff(Adrress.SaveAddresInputBDO, "octopu ", "", "", "", "", "", " ");
            dashboardStuartPage.ChooseTransport(Transport.Bike);
            //dashboardStuartPage.DeliveryNow();
            dashboardStuartPage.RequestDelivery();
            //dashboardStuartPage.Check(/*"Antonio"*/);
        }

        [Test]
        /* Test to do a Delevery in a MotorBikeXL*/
        public void DeliveryMotorbikeXLTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);
            dashboardStuartPage.StartDelivery(ChoosseScenario.RoleListScenario, ChoosseScenario.HappyPathSC);
            dashboardStuartPage.AddPickUp(Adrress.SaveAddressInput, "La Sagrada Familia", "", "", "", "", "", "");
            dashboardStuartPage.AddDropOff(Adrress.SaveAddressInputDO, "John ", "", "", "", "", "", " ");
            dashboardStuartPage.ChooseTransport(Transport.Motorbikexl);
            dashboardStuartPage.DeliveryNow();
            dashboardStuartPage.RequestDelivery();
            //dashboardStuartPage.Check(/*"Antonio"*/);
        }


        [Test]
        /* Test to do a Delevery in a Van*/
        public void DeliveryVanTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);
            dashboardStuartPage.StartDelivery(ChoosseScenario.RoleListScenario, ChoosseScenario.HappyPathSC);
            dashboardStuartPage.AddPickUp(Adrress.SaveAddresInputBDO, "octopu ", "", "", "", "", "", "");
            dashboardStuartPage.AddDropOff(Adrress.SaveAddressInput, "La Sagrada Familia", "", "", "", "", "", " ");
            dashboardStuartPage.ChooseTransport(Transport.Van);
            //dashboardStuartPage.DeliveryNow();
            dashboardStuartPage.RequestDelivery();
            //dashboardStuartPage.Check(/*"Antonio"*/);
        }






    }
}
