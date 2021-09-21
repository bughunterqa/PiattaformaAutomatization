using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class SignUpElements
    {
        [FindsBy(How = How.XPath, Using = "//a[text()='Get started']")]
        public IWebElement btnGetStarted;

        [FindsBy(How = How.Id, Using = "inputName")]
        public IWebElement inputFullName;

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement inputEmail;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement inputPassword;

        [FindsBy(How = How.Id, Using = "password2")]
        public IWebElement inputRepeatPassword;

        [FindsBy(How = How.Id, Using = "checkTerms")]
        public IWebElement checkTerms;

        [FindsBy(How = How.XPath, Using = "//button[text()='Register']")]
        public IWebElement btnRegister;

        [FindsBy(How = How.XPath, Using = "//h3[@class='results-subtitle mt-4 text-success']")]
        public IWebElement successfulMessage;

        [FindsBy(How = How.XPath, Using = "//label[@for='inputName']")]
        protected IWebElement labelFullName;
    }
}
