using NUnit.Framework;
using PiattaformaAutomatization.PageObjects.Pages;
using PiattaformaAutomatization.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.Tests.News
{
    [TestFixture]
    class Assignment : TestBase
    {
        [Test]
        public void AssignToUser()
        {
            Pages.Login
                .EnterCredentials(Credentials.AdminEmail, Credentials.AdminPassword)
                .PressSignIn();

            Pages.AuthorSearching
                .PressCreateArticle()
                .SelectStagingWebsite()
                .SaveAndAssign()
                .PressUsersTab()
                .SearchUser(Credentials.EditorFullName)
                .AssignToSelectedUser();

           
                





        }
    }
}
