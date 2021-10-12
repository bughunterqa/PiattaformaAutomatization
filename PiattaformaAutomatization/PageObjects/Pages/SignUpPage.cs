using Microsoft.Data.SqlClient;
using NUnit.Allure.Steps;
using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.PageObjects.Pages;
using PiattaformaAutomatization.WebElements;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class SignUpPage : SignUpElements
    {
        [AllureStep("Close welcome modal")]
        public SignUpPage PressGetStartedButton()
        {
            WaitUntil.WaitElement(Browser._Driver, btnGetStarted);

            btnGetStarted.Click();

            return this;
        }

        [AllureStep("Fill in profile data - name: {0}, email: {0}@yopmail.com, passord: Test123!")]
        public SignUpPage EnterDataProfile(string name)
        {
            WaitUntil.WaitElement(Browser._Driver, inputFullName);

            inputFullName.SendKeys(name);
            inputEmail.SendKeys(name + "@yopmail.com");
            inputPassword.SendKeys("Test123!");
            inputRepeatPassword.SendKeys("Test123!");
            checkTerms.Click();

            return this;
        }

        public string GenerateFullName()
        {
            return "piatta-qa-" + Browser.Random.Next(0, 10000);
        }



        [AllureStep("Register user")]
        public SignUpPage PressRegister()
        {
            btnRegister.Click();

            return this;
        }


        public string GetSuccessfulMessage()
        {
            WaitUntil.WaitElement(Browser._Driver, successfulMessage);

            string message = successfulMessage.Text;
            return message;
        }

        [AllureStep("Verify account {0}")]
        public LoginPage VerifyUser(string email)
        {
            using (SqlConnection db = new SqlConnection(Browser.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("update AspNetUsers set Status = 1, EmailConfirmed = 1 where Email = @email", db);
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                db.Open();

                command.ExecuteNonQuery();
            }
            return Pages.Login;
        }


    }
}
