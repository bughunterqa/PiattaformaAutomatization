using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.TestData
{
    class Credentials
    {
        public const string EditorFullName = "QA Test";
        public const string EditorEmail = "owazafiss-8421@yopmail.com";
        public const string EditorPassword = "Test123!";

        public const string AdminEmail = "dev@entiredigital.com";
        public const string AdminPassword = "YaWMJWgh5emWQt4";

        public const string DomainYop = "@yopmail.com";
    }

    class Titles
    {
        public const string UsersSummary = "Creators - Summary";
        public const string AuthorSearching = "Creators - Author Searching";
    }

    class Messages
    {
        public const string Registed = "Thank you for registering!!";
        public const string PendingApproveTest = "We're evaluating your Profile!";
        public const string LoremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua";
        public const string InsertImg = "Piattaforma-AQA";
        public const string WhiteListLink = "https://mammemagazine.it/";
    }

    class Images
    {
        public const string InnerImg = "\\images\\pngwing.com.png";
        public const string FeaturedImg = "\\images\\fire.jpg";

    }

    class Scripts
    {
        public const string ScrollTop = "var timeId=setInterval(function(){window.scrollY<document.body.scrollHeight-window.screen.availHeight?window.scrollTo(0,document.body.scrollHeight):(clearInterval(timeId),window.scrollTo(0,0))},500);";
    }
}
