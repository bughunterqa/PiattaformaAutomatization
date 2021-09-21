using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class LoginElements
    {
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement inputEmail;

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement inputPassword;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement btnSignIn;

        [FindsBy(How = How.XPath, Using = "//p[@class='sign']/a")]
        public IWebElement btnResgiterHere;
    }
}
