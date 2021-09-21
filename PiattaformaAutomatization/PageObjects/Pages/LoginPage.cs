using OpenQA.Selenium;
using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class LoginPage : LoginElements
    {


        public LoginPage EnterCredentials (string email, string psw)
        {
            inputEmail.SendKeys(email);
            inputPassword.SendKeys(psw);

            return this;
        }

        public void PressSignIn()
        {
            btnSignIn.Click();
        }

        public SignUpPage PressRegisterHere()
        {
            WaitUntil.WaitElement(Browser._Driver, btnResgiterHere);
            btnResgiterHere.Click();

            return Pages.SignUp;
        }








    }
}
