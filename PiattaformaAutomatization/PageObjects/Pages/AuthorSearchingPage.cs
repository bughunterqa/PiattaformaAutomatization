using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class AuthorSearchingPage : AuthorSearchingElements
    {

        public AuthorSearchingPage PressCreateArticle()
        {
            WaitUntil.WaitElement(Browser._Driver, btnCreate);

            btnCreate.Click();

            return this;
        }

        public CreateTitlePage SelectStagingWebsite()
        {
            WaitUntil.WaitElement(Browser._Driver, btnStagingNotizie);

            btnStagingNotizie.Click();

            return Pages.CreateTitle;
        }
    }
}
