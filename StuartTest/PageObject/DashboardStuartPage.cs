using NUnit.Framework;
using OpenQA.Selenium;
using StuartTest.Handler;
using StuartTest.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StuartTest
{
    public class Transport
    {
        //Locolaizator to kind of transport        
        public static By Bike = By.Id("transport-bike");
        public static By Motorbike = By.Id("transport-motorbike");
        public static By Van = By.Id("transport-van");
        public static By Motorbikexl = By.Id("transport-motorbikexl");
    }

    public class Adrress
    {
        //Locolaizator different Address
        public static By SaveAddressInput = By.Id("savedPlaceFirstLine-1836604");
        public static By SaveAddressInputDO = By.Id("savedPlaceFirstLine-1833918");
        public static By SaveAddresInputBDO = By.Id("savedPlaceFirstLine-1630892");
    }

    public class TimeToDelivery
    {
        //Localizator time to delivery
        public static By Now = By.Id("now");
        public static By Later = By.Id("later");
        public static By SlectDate = By.Id("daySelect");
        public static By slotTime = By.Id("slotSelect");

    }

    public class ChoosseScenario
    {
        //Localizators Choose testing scenarios
        public static By RoleListScenario = By.Id("-label");
        public static By HappyPathSC = By.Id("-happyPath");
        public static By PackageCancelledSC = By.Id("-cancelation");
        public static By ExpiredPackage = By.Id("-expiration");
        public static By DriverReassignement = By.Id("-driverReassignation");
        public static By DriverWaitStatus = By.Id("-driverWaiting");
        public static By ReturnDelivery = By.Id("return");
        

    }

    /*Clase para representar la pagina del formulario empleado*/
    public class DashboardStuartPage : BasePage
    {

        //Localizators

        //Localizators of Page
        protected By Form = By.Id("newJobPage");

        //Localizators Start Popup
        public static By CloseToolTip = By.Id("ScenarioTooltipCloseButton");
        public static By TryToolTip = By.Id("ScenarioTooltipTryButton");

        //Apply or Mode of scenerio
        public static By ApplyScenario = By.Id("ScenarioModalApplyButton");
        public static By ApplyDefault = By.Id("ScenarioModalDefaultButton");
        public static By CloseSC = By.Id("ScenarioModalCloseButton");

        //Localizator popup understood
        protected By Understood = By.XPath("/html/body/div[*]/div/div/div[3]/button/span");

        //Localizators of PickUp
        protected By PickUpButton = By.XPath("//*[@id='pickUpCard-0']/div[1]/div");
        protected By AddressInput = By.Id("pickUpCard-0-fields-field-address");
        protected By FNameInput = By.Id("pickUpCard-0-fields-field-firstname");
        protected By LNameInput = By.Id("pickUpCard-0-fields-field-lastname");
        protected By ComanyInput = By.Id("pickUpCard-0-fields-field-company");
        protected By PhoneInput = By.Id("pickUpCard-0-fields-field-phone");
        protected By EmailInput = By.Id("pickUpCard-0-fields-field-email");
        protected By AddDetailsInput = By.Id("pickUpCard-0-fields-field-comment");
        protected By SaveButtonInput = By.Id("pickUpCard-0-fields-field-saveAddress");


        //Localizators of DropOff
        protected By DropOffButton = By.XPath("//*[@id='dropOffCard-0']/div[1]/h2");
        protected By DOAddressInput = By.Id("dropOffCard-0-fields-field-address");
        protected By DOFNameInput = By.Id("dropOffCard-0-fields-field-firstname");
        protected By DOLNameInput = By.Id("dropOffCard-0-fields-field-lastname");
        protected By DOComanyInput = By.Id("dropOffCard-0-fields-field-company");
        protected By DOPhoneInput = By.Id("dropOffCard-0-fields-field-phone");
        protected By DOEmailInput = By.Id("dropOffCard-0-fields-field-email");
        protected By DOAddDetailsInput = By.Id("dropOffCard-0-fields-field-comment");
        protected By OrderIDInput = By.Id("dropOffCard-0-fields-field-clientReference");
        protected By OrderInfirmotionInput = By.Id("dropOffCard-0-fields-field-packageDescription");


        //Localizator Request Delivery
        protected By Request = By.Id("requestButton");

        //protected By CurrentDay = By.Id($"daySelect-{Time}-04-27");

        //Choose the enviroment
        //Choose the scenario
        public void StartDelivery(By Localizator, By Scenario)
        {
            clickElement(TryToolTip);
            Thread.Sleep(5000);
            try
            {
                
                clickElement(Understood);
                SelectItem(Localizator, Scenario);
                clickElement(ApplyScenario);
                
            }

            catch
            {
                
                SelectItem(Localizator, Scenario);
                clickElement(ApplyScenario);
                clickElement(Understood);
            }


        }




        //Constructor. lanza una excepcion si el titulo de la pagina no es el correcto
        public DashboardStuartPage(IWebDriver driver)
        {
            Driver = driver;
            Thread.Sleep(500);
            waitElement(Form);
            if (!Driver.Title.Equals("New delivery | Stuart"))
                throw new Exception("This is not the Employe Page");

        }

        //Metodo para detectar si el formulario esta cargado
        //Retorna true si el elemento del formulario esta presente
        public bool FormIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, Form);
        }



        //Metodo para incluir direccion
        public void AddPickUp(By SuggestAddress, String address, string firstname, string lastname, string company, string phone, string email, string details)
        {            
            Type(AddressInput, address);
            clickElement(SuggestAddress);
            Type(FNameInput, firstname);
            Type(LNameInput, lastname);
            Type(ComanyInput, company);
            Type(PhoneInput, phone);
            Type(EmailInput, email);
            Type(AddDetailsInput, details);
        }

        public void AddPickUp()
        {
            AddPickUp(Adrress.SaveAddressInput, "La Sagrada Familia", "", "", "", "", "", " ");
        }


        //Metodo para incluir Receptor
        public void AddDropOff(By SuggestAddress, String addressD, string firstnameD, string lastnameD, string companyD, string phoneD, string emailD, string detailsD)
        {            
            Type(DOAddressInput, addressD);
            clickElement(SuggestAddress);
            Type(DOFNameInput, firstnameD);
            Type(DOLNameInput, lastnameD);
            Type(DOComanyInput, companyD);
            Type(DOPhoneInput, phoneD);
            Type(DOEmailInput, emailD);
            Type(DOAddDetailsInput, detailsD);
        }

        //Choose Kind of transport
        public void ChooseTransport(By transport)
        {
            clickwaitElement(transport);
        }


        public void DeliveryNow()
        {
            clickElement(TimeToDelivery.Now);
        }

        public void RequestDelivery()
        {
            clickElement(Request);
        }





        //public void Check(/*string expectedText*/)
        // {
        //     //Tiempo para cargar la web
        //     Thread.Sleep(3000);
        //     string text = Driver.FindElement(FNameInput).Text;
        //     //Una vez guardado se deberia probar asi
        //     //Assert.AreEqual(text, expectedText);
        //     // Hasta que no se guarda el texto no se puede coomprobar
        //     Assert.IsNotNull(FNameInput);
        // } 






    }



}
