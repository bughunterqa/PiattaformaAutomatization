using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class AuthorSearchingElements
    {
        [FindsBy(How = How.CssSelector, Using = "div.page-title-actions button")]
        protected IWebElement btnCreate;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'TEST Staging Notizie')]/parent::a[@class='nav-link']")]
        protected IWebElement btnStagingNotizie;
    }
}
