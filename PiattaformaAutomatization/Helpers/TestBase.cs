using Microsoft.AspNetCore.Hosting;
using NUnit.Framework;


namespace PiattaformaAutomatization
{
    [TestFixture]
    public class TestBase
    {
        

        [SetUp]
        public static void Initialize()
        {
            
           
            Browser.Initialize();
            //UserGenerator.Initialize();
        }

       /* [TestFixtureTearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }*/

        [TearDown]
        public static void TearDown()
        {

            Browser.Close();
            // Implement clean logout for user, remove session storage etc...) 

            //will hack for now
            /*Browser.Goto("");*/

            //if(Pages.TopNavigation.IsLoggedIn())
            //    Pages.TopNavigation.LogOut();

            //if(UserGenerator.LastGeneratedUser != null)
            //    Browser.Goto("????");
        }
    }
}
