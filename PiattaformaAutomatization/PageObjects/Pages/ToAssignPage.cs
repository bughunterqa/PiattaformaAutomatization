using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class ToAssignPage : ToAssignElements
    {

        public ToAssignPage PressUsersTab()
        {
            WaitUntil.WaitElement(Browser._Driver, btnNavUsers);

            btnNavUsers.Click();

            return this;
        } 

        public ToAssignPage SearchUser(string userName)
        {
            WaitUntil.WaitElement(Browser._Driver, inputLeftSearchUsers);

            inputLeftSearchUsers.SendKeys(userName);

            bool userExist = foundUser.Text.Contains("QA Test");
            Assert.AreEqual(userExist, true);

            return this;
        }

        public ToAssignPage AssignToSelectedUser()
        {
            foundUser.Click();
            btnRightArrowUsers.Click();
            bntSave.Click();

            Assert.AreEqual("Data saved!", GetMessage());

            return this;
        }


        public string GetMessage()
        {
            WaitUntil.WaitElementByLocator(Browser._Driver, message);

            return _message.Text;
        }

    }
}
