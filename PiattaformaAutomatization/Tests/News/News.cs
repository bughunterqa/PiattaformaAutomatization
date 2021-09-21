using NUnit.Framework;
using PiattaformaAutomatization.PageObjects.Pages;
using PiattaformaAutomatization.TestData;


namespace PiattaformaAutomatization.Tests.News
{
    [TestFixture]
    class News : TestBase
    {
        [Test]
        public void ArticlePublicationByAdmin()
        {
            Pages.Login
                .EnterCredentials(Credentials.AdminEmail, Credentials.AdminPassword)
                .PressSignIn();

            Assert.AreEqual(Browser.Title, Titles.AuthorSearching);

            Pages.AuthorSearching
                .PressCreateArticle()
                .SelectStagingWebsite()
                .AssignToMe()
                .EnterDataContent()
                .SelectCategory()
                .AddTag()
                .AddImgInContent(Images.InnerImg)
                .AddInnerLink(Messages.WhiteListLink)
                .FillFrame()
                .EnterSeoInfo()
                .EnterFeaturedImage(Images.FeaturedImg)
                .PressSaveAndPublish();
        }
    }
}
