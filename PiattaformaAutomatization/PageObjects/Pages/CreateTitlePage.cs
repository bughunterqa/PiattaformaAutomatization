using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class CreateTitlePage : CreateTitleElements
    {
        public CreateTitlePage ChangeTopic()
        {
            WaitUntil.WaitElement(Browser._Driver, inputTopic);

            inputTopic.SendKeys("Piatta-aqa-" + Browser.Random.Next(0, 10000) );

            return this;
        }

        public ArticleViewPage AssignToMe()
        {
            WaitUntil.WaitSomeInterval(1);

            btnAssignToMe.Click();

            return Pages.ArticleView;

            
        }

        public ToAssignPage SaveAndAssign()
        {
            WaitUntil.WaitSomeInterval(1);

            btnSaveAndAssign.Click();

            return Pages.ToAssign;


        }
    }
}
