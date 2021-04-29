using NUnit.Framework;
using StuartTest.PageObject;
using StuartTest.Setup;


namespace StuartTest.TestCase
{
    /*
     Class containing the test cases
     */
    [TestFixture]
    public class Tests : BaseTest
    {        
        //Test to check the correct login
        [Test]
        public void SuccesfulLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);

            Assert.IsTrue(dashboardStuartPage.FormIsPresent()); 
        }

        //Test to check the Incorrect User Login
        [TestCase(TestData.Wrongemail, TestData.Password)]
        public void WrongUserLoginTest(string Wrongemail, string Password)
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs(Wrongemail, Password);
            
            Assert.IsTrue(loginPage.LogIsPresent());
        }

        //Test to check the Incorrect Password Login
        [TestCase(TestData.email, TestData.WrongPassword)]
        public void WrongPasswordLoginTest(string email, string WrongPassword)
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs(email, WrongPassword);

            Assert.IsTrue(loginPage.LogIsPresent());
        }

        /* Test to do a Delevery in a Motorbike*/
        [Test]       
        public void DeliveryMotorBikeTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);
            dashboardStuartPage.StartDelivery(ChoosseScenario.RoleListScenario, ChoosseScenario.HappyPathSC);
            dashboardStuartPage.AddPickUp();
            dashboardStuartPage.AddDropOff();
            dashboardStuartPage.ChooseTransport(Transport.Motorbike);
            dashboardStuartPage.DeliveryNow();
            dashboardStuartPage.RequestDelivery();
        }


        /* Test to do a Delevery in a Bike*/
        [Test]
        public void DeliveryBikeTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);
            dashboardStuartPage.StartDelivery(ChoosseScenario.RoleListScenario, ChoosseScenario.HappyPathSC);
            dashboardStuartPage.AddPickUp();
            dashboardStuartPage.AddDropOff();
            dashboardStuartPage.ChooseTransport(Transport.Bike);
            dashboardStuartPage.DeliveryNow();
            dashboardStuartPage.RequestDelivery();
        }

        /* Test to do a Delevery in a MotorBikeXL*/
        [Test]
        public void DeliveryMotorbikeXLTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);
            dashboardStuartPage.StartDelivery(ChoosseScenario.RoleListScenario, ChoosseScenario.HappyPathSC);
            dashboardStuartPage.AddPickUp();
            dashboardStuartPage.AddDropOff(Adrress.SaveAddressInputDO, "John ", "", "", "", "", "", " ");
            dashboardStuartPage.ChooseTransport(Transport.Motorbikexl);
            dashboardStuartPage.DeliveryNow();
            dashboardStuartPage.RequestDelivery();            
        }

        /* Test to do a Delevery in a Van*/
        [Test]
        public void DeliveryVanTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginAs();
            DashboardStuartPage dashboardStuartPage = new DashboardStuartPage(Driver);
            dashboardStuartPage.StartDelivery(ChoosseScenario.RoleListScenario, ChoosseScenario.HappyPathSC);
            dashboardStuartPage.AddPickUp(Adrress.SaveAddresInputBDO, "octopu ", "", "", "", "", "", "");
            dashboardStuartPage.AddDropOff(Adrress.SaveAddressInput, "La Sagrada Familia", "", "", "", "", "", " ");
            dashboardStuartPage.ChooseTransport(Transport.Van);
            dashboardStuartPage.DeliveryNow();
            dashboardStuartPage.RequestDelivery();
        }






    }
}
