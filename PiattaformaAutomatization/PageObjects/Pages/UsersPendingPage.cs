using NUnit.Allure.Steps;
using OpenQA.Selenium;
using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class UsersPendingPage : UsersPendingElements
    {
        [AllureStep("Navigate to Users > Pending page")]
        public void Goto()
        {
            Browser.Goto("/Users/Pending");
        }




        [AllureStep("Search the user {0}")]
        public UsersPendingPage SearchUser(string name)
        {
            WaitUntil.WaitElement(Browser._Driver, inputSearch);

            inputSearch.SendKeys(name);

            WaitUntil.WaitSomeInterval(1);
            return this;
        }



        [AllureStep("Approve the test article")]
        public UsersPendingPage ApproveExam()
        {
            WaitUntil.WaitElement(Browser._Driver, btnApprove);

            btnApprove.Click();

            return this;
        }



        [AllureStep("Open profile of the user")]
        public UserOverviewPage OpenUserProfile()
        {
            WaitUntil.WaitElement(Browser._Driver, btnShow);

            btnShow.Click();

            return Pages.UserOverview;
        }

    }
}
