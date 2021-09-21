using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class SelectExamTypeElements
    {
        [FindsBy(How = How.Id, Using = "FromLanguageId")]
        public IWebElement dbFromLanguage;

        [FindsBy(How = How.Id, Using = "TestSubmitButton")]
        public IWebElement btnStart;
    }
}
