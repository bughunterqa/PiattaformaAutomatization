using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class CreateTitleElements
    {
        [FindsBy(How = How.Id, Using = "Title")]
        protected IWebElement inputTopic;

        [FindsBy(How = How.Id, Using = "btnAssign")]
        protected IWebElement btnSaveAndAssign;

        [FindsBy(How = How.Id, Using = "btnAssignToMe")]
        protected IWebElement btnAssignToMe;
    }
}
