using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;


namespace PiattaformaAutomatization.PageObjects.Pages
{
    public static class Pages
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static UserSummaryPage UserSummary
        {
            get { return GetPage<UserSummaryPage>(); }
        }

        public static CompleteProfilePage CompleteProfile
        {
            get { return GetPage<CompleteProfilePage>(); }
        }

        public static SignUpPage SignUp
        {
            get { return GetPage<SignUpPage>(); }
        }

        public static YopMailPage YopMail
        {
            get { return GetPage<YopMailPage>(); }
        }

        public static SelectExamTypePage SelectExamType
        {
            get { return GetPage<SelectExamTypePage>(); }
        }

        public static ExamPage EditorExam
        {
            get { return GetPage<ExamPage>(); }
        }

        public static AuthorSearchingPage AuthorSearching
        {
            get { return GetPage<AuthorSearchingPage>(); }
        }

        public static CreateTitlePage CreateTitle
        {
            get { return GetPage<CreateTitlePage>(); }
        }

        public static ArticleViewPage ArticleView
        {
            get { return GetPage<ArticleViewPage>(); }
        }

        public static ToAssignPage ToAssign
        {
            get { return GetPage<ToAssignPage>(); }
        }

        public static UsersPendingPage UsersPending
        {
            get { return GetPage<UsersPendingPage>(); }
        }

        public static UserOverviewPage UserOverview
        {
            get { return GetPage<UserOverviewPage>(); }
        }
    }
}
