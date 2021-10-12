using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class UserOverviewElements
    {
        [FindsBy(How = How.Id, Using = "test")]
        protected IWebElement tabEditorTest;

        [FindsBy(How = How.Id, Using = "testPR")]
        protected IWebElement tabProofreaderTest;




        [FindsBy(How = How.XPath, Using = "//strong[text()='Content']/parent::td/parent::tr/following-sibling::tr/td/p")]
        protected IWebElement testArticle;
    }
}
