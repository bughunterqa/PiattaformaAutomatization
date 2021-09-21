using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class CompleteProfileElements
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='FirstName']")]
        public IWebElement inputFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@name='LastName']")]
        public IWebElement inputLastName;

        [FindsBy(How = How.XPath, Using = "//input[@name='BirthCityName']")]
        public IWebElement inputBirthCityName;

        [FindsBy(How = How.XPath, Using = "//input[@name='ResidenceAddress']")]
        public IWebElement inputResidenceAddress;

        [FindsBy(How = How.XPath, Using = "//input[@name='ResidenceCityName']")]
        public IWebElement inputResidenceCityName;

        [FindsBy(How = How.XPath, Using = "//input[@name='ResidenceZipCode']")]
        public IWebElement inputResidenceZipCode;

        [FindsBy(How = How.XPath, Using = "//input[@name='MobilePhone']")]
        public IWebElement inputMobilePhone;

        [FindsBy(How = How.XPath, Using = "//input[@id='BirthDate']")]
        public IWebElement inputBirthDate;

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave;
    }
}
