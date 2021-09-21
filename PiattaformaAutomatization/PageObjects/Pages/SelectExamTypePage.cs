using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class SelectExamTypePage : SelectExamTypeElements
    {

        public string GetFromLanguage()
        {
            WaitUntil.WaitElement(Browser._Driver, dbFromLanguage);

            string fromLang = dbFromLanguage.Text;

            return fromLang;
        }

        public ExamPage StartExam()
        {
            WaitUntil.WaitElement(Browser._Driver, btnStart);
            btnStart.Click();

            return Pages.EditorExam;
        }
    }
}
