using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PiattaformaAutomatization.PageObjects;
using PiattaformaAutomatization.TestData;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    [TestFixture]
    [AllureNUnit]
    public class Tests : TestBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("vladislav rybalka")]
        [AllureSuite("Registration")]
        [AllureSubSuite("Editor Registration")]
        public void Login()
        {
            Pages.Login
                .EnterEmail(Credentials.EditorEmail)
                .EnterPassword(Credentials.EditorPassword)
                .PressSignIn();

            Assert.AreEqual(Browser.Title, Titles.UsersSummary);
        }

        [Test]
        public void EditorRegistration()
        {
            string fullName = Pages.SignUp.GenerateFullName();

            Pages.Login
                .PressRegisterHere()
                .PressGetStartedButton()
                .EnterDataProfile(fullName)
                .PressRegister();

            Assert.AreEqual(Messages.Registed, Pages.SignUp.GetSuccessfulMessage());

            Pages.SignUp
                .VerifyUser(fullName + Credentials.DomainYop)
                .EnterEmail(fullName + Credentials.DomainYop)
                .EnterPassword(Credentials.EditorPassword)
                .PressSignIn();
            Pages.CompleteProfile
                .EnterDataProfile(fullName)
                .SaveProfileData()
                .GetStartedEditorExam()
                .StartExam()
                .EnterTestContent();

            Assert.AreEqual(Pages.EditorExam.GetExpectedCountWords(), Pages.EditorExam.GetActaulCountWords());

            Pages.EditorExam
                .SendTestContent();

            Assert.AreEqual(Messages.PendingApproveTest, Pages.UserSummary.GetMessagePendingApproveTest());

            Pages.Login
                .EnterEmail(Credentials.AdminEmail)
                .EnterPassword(Credentials.AdminPassword)
                .PressSignIn();
            Pages.UsersPending
                .Goto();
                

        }

        [Test]
        public void ProofreaderRegistration()
        {
            string fullName = Pages.SignUp.GenerateFullName();

            Pages.Login
                .PressRegisterHere()
                .PressGetStartedButton()
                .EnterDataProfile(fullName)
                .PressRegister();

            Assert.AreEqual(Messages.Registed, Pages.SignUp.GetSuccessfulMessage());

            Pages.YopMail
                .NavigateYopMail()
                .CheckEmail(fullName)
                .GoToFrame()
                .VerifyAccount()
                .EnterDataProfile(fullName)
                .SaveProfileData()
                .GetStartedProofreaderExam()
                .StartExam()
                .EnterCorrectedContent()
                .SendTestContent();

            Assert.AreEqual(Messages.PendingApproveTest, Pages.UserSummary.GetMessagePendingApproveTest());

        }


        [Test]
        public void TranslatorRegistration()
        {
            string fullName = Pages.SignUp.GenerateFullName();

            Pages.Login
                .PressRegisterHere()
                .PressGetStartedButton()
                .EnterDataProfile(fullName)
                .PressRegister();

            Assert.AreEqual(Messages.Registed, Pages.SignUp.GetSuccessfulMessage());

            Pages.SignUp
                .VerifyUser(fullName + Credentials.DomainYop)
                .EnterEmail(fullName + Credentials.DomainYop)
                .EnterPassword(Credentials.EditorPassword)
                .PressSignIn();
            Pages.CompleteProfile
                .EnterDataProfile(fullName)
                .SaveProfileData()
                .GetStartedTranslatorExam()
                .StartExam()
                .EnterCorrectedContent()
                .SendTestContent();

            Assert.AreEqual(Messages.PendingApproveTest, Pages.UserSummary.GetMessagePendingApproveTest());
        }
    }
}