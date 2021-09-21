using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects
{
    public class SignUpPage : SignUpElements
    {
        public SignUpPage PressGetStartedButton()
        {
            WaitUntil.WaitElement(Browser._Driver, btnGetStarted);

            btnGetStarted.Click();

            return this;
        }

        public SignUpPage EnterDataProfile(string name)
        {
            WaitUntil.WaitElement(Browser._Driver, inputFullName);

            inputFullName.SendKeys(name);
            inputEmail.SendKeys(name + "@yopmail.com");
            inputPassword.SendKeys("Test123!");
            inputRepeatPassword.SendKeys("Test123!");
            checkTerms.Click();

            return this;
        }

        public string GenerateFullName()
        {
            return "piatta-qa-" + Browser.Random.Next(0, 10000);
        }      
            
        


        public SignUpPage PressRegister()
        {
            btnRegister.Click();

            return this;
        }


        public string GetSuccessfulMessage()
        {
            WaitUntil.WaitElement(Browser._Driver, successfulMessage);

            string message = successfulMessage.Text;
            return message;
        }


    }
}
