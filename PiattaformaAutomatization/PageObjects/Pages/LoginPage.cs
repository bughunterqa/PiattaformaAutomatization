using Microsoft.Data.SqlClient;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Allure.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.WebElements;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PiattaformaAutomatization.PageObjects.Pages
{
    [AllureNUnit]
    public class LoginPage : LoginElements
    {
        [AllureStep("Enter Email - {0}")]
        public LoginPage EnterEmail (string email)
        {
            if(Browser.CurrentURL != "https://creators-anuitex2.contents.com/login")
            {
                Browser.Goto("login");
            }
            inputEmail.SendKeys(email);

            return this;
        }

        [AllureStep("Enter password -  {0}")]
        public LoginPage EnterPassword(string psw)
        {
            inputPassword.SendKeys(psw);

            return this;
        }

        [AllureStep("Click on SignIn button")]
        public void PressSignIn()
        {
            btnSignIn.Click();
        }

        [AllureStep("Navigate to register form")]
        public SignUpPage PressRegisterHere()
        {

            WaitUntil.WaitElement(Browser._Driver, btnResgiterHere);
            btnResgiterHere.Click();

            return Pages.SignUp;
        }


       


       /* public void ConnDB()
        {
            DataTable dt = new DataTable();
            int rows_returned;


            string connectionString = GetConnectionString();

            string query = "update AspNetUsers set Status = 1, EmailConfirmed = 1 where Email = 'gillouyaquise-6629@yopmail.com'";

            using (SqlConnection db = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, db);
                db.Open();

                SqlDataReader reader = command.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                db.Close();
                rows_returned = adapter.Fill(dt);
            } 
        }*/


      







    }
}
