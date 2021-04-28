using OpenQA.Selenium;
using StuartTest.Handler;
using StuartTest.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartTest.PageObject
{
    public class LoginPage : BasePage
    {
  
        //Localizadores
        protected By LoginTitle = By.XPath("//title[contains(text(),'Stuart')]");
        protected By UserInput = By.Id("email");
        protected By PasswordInput = By.Id("password");
        protected By LoginButton = By.Id("logInButton");
        //protected By LoginTitle = By.Id("Stuart");

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            waitElement(LoginTitle);
            if (!Driver.Title.Equals("Stuart"))
                throw new Exception("This ir not a Login page");
        }

        //Method to Know is in the login Page
        public bool LogIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, LoginTitle);
        }



        //Metodo para escribir la Contraseña


        //Metodo para clicar en el Login
        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButton).Click();
        }

        //Metodo para loguearnos. Retorna la pagina de formulario de empleado
        public LoginPage LoginAs(string user, string password)
        {
            Type(UserInput, user);
            Type(PasswordInput, password);
            ClickLoginButton();
            return new LoginPage(Driver);

        }

        public LoginPage LoginAs()
        {
            LoginAs("strt.wa+test@gmail.com", "Test!234");
            return new LoginPage(Driver);

        }
    }
}
