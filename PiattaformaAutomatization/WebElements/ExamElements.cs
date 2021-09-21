using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
     public class ExamElements
    {
        [FindsBy(How = How.Id, Using = "tinymce")]
        protected IWebElement inputContent;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Content Word')]")]
        protected IWebElement expectedCountWords;

        [FindsBy(How = How.XPath, Using = "//input[@id='testo']/parent::div/div/div/span")]
        protected IWebElement actualCountWords;

        [FindsBy(How = How.Id, Using = "btnSend")]
        protected IWebElement btnSend;


        protected readonly By iframe = By.Id("mytextarea_ifr");
        protected IWebElement _iframe => Browser._Driver.FindElement(iframe);
    }
}
