using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class YopMailElements
    {
        [FindsBy(How = How.CssSelector, Using = "td.unlien a")]
        public IWebElement btnRandomMail;

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement getRandomMail;

        [FindsBy(How = How.XPath, Using = "//div[@id='refreshbut']/button")]
        public IWebElement btnCheckEmail;

        [FindsBy(How = How.XPath, Using = "//div[@id='mail']/div/table[2]/tbody/tr/td/p[2]/a")]
        public IWebElement btnVerify;

        [FindsBy(How = How.XPath, Using = "//table[@align='center']/tbody/tr/td/ul/li[2]")]
        public IWebElement getPassword;


        public readonly By iframe = By.XPath("//iframe[@id='ifmail']");
        public IWebElement _iframe => Browser._Driver.FindElement(iframe);

    }
}
