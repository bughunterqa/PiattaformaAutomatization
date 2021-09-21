using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class ToAssignElements
    {
        // Tabs
        [FindsBy(How = How.Id, Using = "btnNavUsers")]
        protected IWebElement btnNavUsers;

        [FindsBy(How = How.Id, Using = "btnNavGroups")]
        protected IWebElement btnNavGroups;

        [FindsBy(How = How.Id, Using = "btnNavRules")]
        protected IWebElement btnNavRules;

        [FindsBy(How = How.Id, Using = "bntSave")]
        protected IWebElement bntSave;

        // Items for Users tab
        [FindsBy(How = How.XPath, Using = "//div[@id='transfer_users']/div/div[2]/div[@class='transfer-double-content-left']/div[2]/div/div/input[@placeholder='search']")]
        protected IWebElement inputLeftSearchUsers;

        /*[FindsBy(How = How.XPath, Using = "//*[contains(text(), 'QA Test')]/parent::div/parent::li")]
        protected IWebElement editorENG;*/
        
        [FindsBy(How = How.XPath, Using = "//li[@style='display: block;']/div/label")]
        protected IWebElement foundUser;

        [FindsBy(How = How.XPath, Using = "//div[@id='transfer_users']/div/div/div[2]/div[1]/i")]
        protected IWebElement btnRightArrowUsers;

        [FindsBy(How = How.XPath, Using = "//div[@id='transfer_users']/div/div/div[2]/div[2]/i")]
        protected IWebElement btnLeftArrowUsers;



        // Messages
        protected readonly By message = By.Id("ErrorAlertMessage_OkMessage");
        protected IWebElement _message => Browser._Driver.FindElement(message);





    }
}
