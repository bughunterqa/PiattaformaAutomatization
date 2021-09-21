using NUnit.Framework;
using PiattaformaAutomatization.PageObjects;
using PiattaformaAutomatization.TestData;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    [TestFixture]
    public class Tests : TestBase
    {
        [Test]
        public void Login()
        {
            Pages.Login
                .EnterCredentials(Credentials.EditorEmail, Credentials.EditorPassword)
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

            Pages.YopMail
                .NavigateYopMail()
                .CheckEmail(fullName)
                .GoToFrame()
                .VerifyAccount()
                .EnterDataProfile(fullName)
                .SaveProfileData()
                .GetStartedEditorExam()
                .StartExam()
                .EnterTestContent();

            Assert.AreEqual(Pages.EditorExam.GetExpectedCountWords(), Pages.EditorExam.GetActaulCountWords());

            Pages.EditorExam
                .SendTestContent();

            Assert.AreEqual(Messages.PendingApproveTest, Pages.UserSummary.GetMessagePendingApproveTest());
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
    }
}