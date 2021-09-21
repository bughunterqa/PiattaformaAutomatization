using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class UserSummaryPage : UserSummaryElements
    {
        public SelectExamTypePage GetStartedEditorExam()
        {
            WaitUntil.WaitElement(Browser._Driver, btnGetStartedEditorExam);

            btnGetStartedEditorExam.Click();

            return Pages.SelectExamType;
        }

        public SelectExamTypePage GetStartedProofreaderExam()
        {
            WaitUntil.WaitElement(Browser._Driver, btnGetStartedProofreaderExam);

            btnGetStartedProofreaderExam.Click();

            return Pages.SelectExamType;
        }

        public string GetMessagePendingApproveTest()
        {
            WaitUntil.WaitElement(Browser._Driver, messagePendingApproveTest);

            string message = messagePendingApproveTest.Text;

            return message;
        }




    }
}
