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
    public class CompleteProfilePage : CompleteProfileElements
    {
        [AllureStep("Complete profile data")]
        public CompleteProfilePage EnterDataProfile(string name)
        {
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.Last());

            WaitUntil.WaitElement(Browser._Driver, inputFirstName);
            inputFirstName.SendKeys(name);
            inputLastName.SendKeys(name);
            inputBirthCityName.SendKeys("Kharkiv");
            inputResidenceAddress.SendKeys("Kirgizkaya street 22");
            inputResidenceCityName.SendKeys("Kharkiv");
            inputResidenceZipCode.SendKeys("221322");
            inputMobilePhone.SendKeys("380997656734");
            inputBirthDate.SendKeys("10/10/1993");

            return this;
        }

        [AllureStep("Save profile data")]
        public UserSummaryPage SaveProfileData()
        {
            btnSave.Click();

            return Pages.UserSummary;
        }
    }
}
