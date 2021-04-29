using OpenQA.Selenium;
using StuartTest.Handler;
using StuartTest.Setup;
using System;


namespace StuartTest.PageObject
{
    public class LoginPage : BasePage
    {
  
        //Localizators
        protected By LoginTitle = By.XPath("//title[contains(text(),'Stuart')]");
        protected By UserInput = By.Id("email");
        protected By PasswordInput = By.Id("password");
        protected By LoginButton = By.Id("logInButton");
        //protected By LoginTitle = By.Id("Stuart");

        //Builder throws an exception if the title of the page is not correct
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

        //Methot to perform the click in the login button
        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButton).Click();
        }

        //Login method Return the form page for new job
        public LoginPage LoginAs(string user, string password)
        {
            Type(UserInput, user);
            Type(PasswordInput, password);
            ClickLoginButton();
            return new LoginPage(Driver);

        }

        //Method to overload the function login with the correct login
        public LoginPage LoginAs()
        {
            LoginAs("strt.wa+test@gmail.com", "Test!234");
            return new LoginPage(Driver);

        }
    }
}
