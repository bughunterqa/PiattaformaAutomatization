using Microsoft.AspNetCore.Hosting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PiattaformaAutomatization
{
    public class Browser
    {
        public IWebDriver WebDriver { get; set; }
        private static string baseUrl = "https://creators-anuitex2.contents.com/";
        private static IWebDriver webDriver = new ChromeDriver();



        public Browser(IWebDriver webDriver)
        {     
             WebDriver = webDriver;
        }




        public static void Initialize()
        {
            webDriver.Manage().Cookies.DeleteAllCookies();
            webDriver.Manage().Window.Maximize();
            Goto("login");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return webDriver.Url; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver _Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static Random Random
        {
            get { return new Random(); }
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static string RootPath()
        {
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var directoryName = System.IO.Path.GetDirectoryName(currentPath);
            var directory = System.IO.Path.GetDirectoryName(directoryName);
            var mainpath = directory.Replace("\\bin\\Debug", "");

            return mainpath;
        }

        public static void ScrollTop(string script)
        {    
            var scrollJS = (IJavaScriptExecutor)webDriver;
            scrollJS.ExecuteScript(script);
        }

        public static string GetConnectionString()
        {
            return "Server=tcp:15.237.142.222,1433;Initial catalog=Test-EDigital1;User ID=anuitex;Password=Pass4contents;TrustServerCertificate=True;";
        }
    }
}
