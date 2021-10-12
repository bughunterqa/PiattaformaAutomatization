using NUnit.Allure.Steps;
using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class UserOverviewPage : UserOverviewElements
    {
        [AllureStep("Open page for review Editor test")]
        public UserOverviewPage OpenEditorTest()
        {
            WaitUntil.WaitElement(Browser._Driver, tabEditorTest);

            tabEditorTest.Click();

            return Pages.UserOverview;
        }



        [AllureStep("Open page for review Proofreader test")]
        public UserOverviewPage OpenProofreaderTest()
        {
            WaitUntil.WaitElement(Browser._Driver, tabProofreaderTest);

            tabProofreaderTest.Click();

            return Pages.UserOverview;
        }

      /*  public string GetTestArticle()
        {

        }*/
    }
}
