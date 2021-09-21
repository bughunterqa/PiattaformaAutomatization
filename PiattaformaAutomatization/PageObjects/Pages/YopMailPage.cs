using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class YopMailPage : YopMailElements
    {

        public YopMailPage GenerateRandomMail()
        {
            btnRandomMail.Click();

            return this;
        }


        public YopMailPage CheckEmail(string email)
        {
            //WaitUntil.WaitElement(Browser._Driver, getRandomMail);

            getRandomMail.SendKeys(email);
            btnCheckEmail.Click();

            return this;
        }

        public YopMailPage GoToFrame()
        {
            WaitUntil.WaitFrame(Browser._Driver, iframe);

            return this;
        }

        public string GetPassword()
        {
            WaitUntil.WaitElement(Browser._Driver, getPassword);

            string password = getPassword.Text;
            password = password.Substring(10);

            return password;
        }

        public YopMailPage NavigateYopMail()
        {
            Browser._Driver.Navigate().GoToUrl("https://yopmail.com/");

            return this;
        }

        /*public YopMailPage ClearOldEmail()
        {
            WaitUntil.WaitElement(Browser._Driver, getRandomMail);

            getRandomMail.Clear();

            return this;
        }*/

        public CompleteProfilePage VerifyAccount()
        {
            WaitUntil.WaitElement(Browser._Driver, btnVerify);

            btnVerify.Click();

            return Pages.CompleteProfile;
        }
    }
}
