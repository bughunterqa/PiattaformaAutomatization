using PiattaformaAutomatization.PageObjects.Pages;
using TechTalk.SpecFlow;
using PiattaformaAutomatization.TestData;
using PiattaformaAutomatization;
using NUnit.Framework;

namespace SpecFlowPiatta.Spec.Steps
{
    [Binding]
    public sealed class LoginSteps
    {        

        [Given(@"I enter email")]
        public void EnterEmail()
        {
            Browser.Initialize();
            Pages.Login.EnterEmail("dev@entiredigital.com");
        }

        [Given(@"I enter password '(.*)'")]
        public void EnterPassword(string psw)
        {
            Pages.Login.EnterPassword(psw);
        }


        [When(@"I click login")]
        public void SignIn()
        {
            Pages.Login.PressSignIn();
        }

        [Then(@"Admin is logged '(.*)'")]
        public void GetPageTitle(string result)
        {
            Assert.AreEqual(Browser.Title, result);
        }
    }
}
