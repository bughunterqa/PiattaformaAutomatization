using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.TestData;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class ExamPage : ExamElements
    {
        public int GetExpectedCountWords()
        {
            WaitUntil.WaitElement(Browser._Driver, expectedCountWords);

            string minCountWords = expectedCountWords.Text;
            minCountWords = minCountWords.Substring(15, 3);
            int countWords = Convert.ToInt32(minCountWords);

            return countWords;
        }



        public ExamPage EnterTestContent()
        {
            int expectedCountWords = GetExpectedCountWords();

            var multiplied = string.Join(" ", Enumerable.Repeat("anuitex ", expectedCountWords).ToArray());

            WaitUntil.WaitFrame(Browser._Driver, iframe);

            inputContent.SendKeys(multiplied);

            Browser._Driver.SwitchTo().DefaultContent();

            return this;
        }

        public ExamPage EnterCorrectedContent()
        {
            WaitUntil.WaitFrame(Browser._Driver, iframe);
            WaitUntil.WaitSomeInterval(1);
            inputContent.SendKeys(Messages.LoremIpsum);

            Browser._Driver.SwitchTo().DefaultContent();

            return this;
        }

        public int GetActaulCountWords()
        {
            WaitUntil.WaitElement(Browser._Driver, actualCountWords);

            int countWords = Convert.ToInt32(actualCountWords.Text);

            return countWords;
        }

        public UserSummaryPage SendTestContent()
        {
            WaitUntil.WaitElement(Browser._Driver, btnSend);

            btnSend.Click();

            return Pages.UserSummary;
        }
    }
}
