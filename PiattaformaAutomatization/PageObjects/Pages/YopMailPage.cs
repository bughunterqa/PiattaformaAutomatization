using NUnit.Allure.Steps;
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

        [AllureStep("Check email - {0}@yopmail.com")]
        public YopMailPage CheckEmail(string email)
        {
            //WaitUntil.WaitElement(Browser._Driver, getRandomMail);
            getRandomMail.Clear();
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

        [AllureStep("Navigate to site with disposable mails")]
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

        [AllureStep("Go to link for verify account")]
        public CompleteProfilePage VerifyAccount()
        {
            WaitUntil.WaitElement(Browser._Driver, btnVerify);

            btnVerify.Click();

            

            var tabs = Browser._Driver.WindowHandles;
            if (tabs.Count > 1)
            {
                Browser._Driver.SwitchTo().Window(tabs[0]);
                Browser._Driver.Close();
                Browser._Driver.SwitchTo().Window(tabs[1]);
            }

            return Pages.CompleteProfile;
        }
    }
}
