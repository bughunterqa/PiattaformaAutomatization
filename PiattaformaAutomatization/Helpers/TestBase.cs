using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PiattaformaAutomatization.PageObjects.Pages;
using System.IO;

namespace PiattaformaAutomatization
{
    [TestFixture]
    public class TestBase
    {


        [SetUp]
        public void Initialize()
        {
            Browser.Initialize();
        }


        [OneTimeTearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }


        [TearDown]
        public static void TearDown()
        {
            //Browser.Goto("");

        }
    }
}
