using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class UserSummaryElements
    {
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Editor Exam')]/parent::div/div/a")]
        protected IWebElement btnGetStartedEditorExam;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'ProofReader Exam')]/parent::div/div/a")]
        protected IWebElement btnGetStartedProofreaderExam;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Translator')]/parent::div/div/a")]
        protected IWebElement btnGetStartedTranslatorExam;

        [FindsBy(How = How.CssSelector, Using = "div.row div.col-md-12 div h5")]
        protected IWebElement messagePendingApproveTest;
    }
}


