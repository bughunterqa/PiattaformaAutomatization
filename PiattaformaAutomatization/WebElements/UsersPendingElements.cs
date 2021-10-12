using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class UsersPendingElements
    {
        [FindsBy(How = How.Id, Using = "FSearch")]
        protected IWebElement inputSearch;

        [FindsBy(How = How.XPath, Using = "//button[@title='Approve']")]
        protected IWebElement btnApprove;

        [FindsBy(How = How.XPath, Using = "//tr[@class='odd']/td[8]/a")]
        protected IWebElement btnShow;
    }
}
