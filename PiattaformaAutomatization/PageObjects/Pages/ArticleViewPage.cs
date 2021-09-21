using PiattaformaAutomatization.Helpers;
using PiattaformaAutomatization.TestData;
using PiattaformaAutomatization.WebElements;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Reflection;
using System;

namespace PiattaformaAutomatization.PageObjects.Pages
{
    public class ArticleViewPage : ArticleViewElements
    {
       
        public ArticleViewPage EnterDataContent()
        {
            WaitUntil.WaitElement(Browser._Driver, inputTopic);


            inputTopic.SendKeys(Messages.LoremIpsum);
            inputHomePageTitle.SendKeys(Messages.LoremIpsum);
            inputAltTitle.SendKeys(Messages.LoremIpsum);
            inputSummary.SendKeys(Messages.LoremIpsum);

            return this;
        }

        public ArticleViewPage SelectCategory()
        {
            WaitUntil.WaitElement(Browser._Driver, selectCategory);

            var box = new SelectElement(selectCategory);
            box.SelectByIndex(Browser.Random.Next(0,30));

            return this;
        }

        public ArticleViewPage AddTag()
        {
            WaitUntil.WaitElement(Browser._Driver, inputTag);

            inputTag.SendKeys("abiti");
            inputTag.SendKeys(Keys.Enter);
            btnAddTag.Click();

            Assert.AreEqual(GetTagModal(), "Ok!");

            btnOK.Click();

            return this;
        }

        public string GetTagModal()
        {
            WaitUntil.WaitElement(Browser._Driver, btnOK);

            string message = modalOk.Text;

            return message;
        }

        public ArticleViewPage AddImgInContent(string imagePuth)
        {
            WaitUntil.WaitElement(Browser._Driver, btnInsertImg);

            btnInsertImg.Click();

            WaitUntil.WaitElement(Browser._Driver, inputModalTitleImg);

            inputModalTitleImg.SendKeys(Messages.InsertImg);
            inputModalAltTextImg.SendKeys(Messages.InsertImg);
            inputModalCaptionImg.SendKeys(Messages.InsertImg);
            inputModalDescriptionImg.SendKeys(Messages.InsertImg);
            inputModalSourceUrlImg.SendKeys(Messages.InsertImg);

            var boxName = new SelectElement(selectModalSourceNameImg);
            boxName.SelectByIndex(Browser.Random.Next(1, 9));

            var boxAlign = new SelectElement(selectModalAlignImg);
            boxAlign.SelectByIndex(Browser.Random.Next(1, 4));

            var boxLinkTo = new SelectElement(selectModalLinkToImg);
            boxLinkTo.SelectByIndex(Browser.Random.Next(1, 3));

            var boxDimension = new SelectElement(selectModalDimensionImg);
            boxDimension.SelectByIndex(Browser.Random.Next(1, 4));

            inputModalImg.SendKeys(Browser.RootPath() + imagePuth);
            btnAddImage.Click();

            WaitUntil.WaitSomeInterval(5);

            return this;
        }


        public ArticleViewPage AddInnerLink(string link)
        {
            WaitUntil.WaitElement(Browser._Driver, btnAddInnerLink);

            btnAddInnerLink.Click();

            WaitUntil.WaitElement(Browser._Driver, inputUrl);

            inputUrl.SendKeys(link);
            inputTitleLink.SendKeys(link);
            btnSaveLink.Click();

            return this;
        }

        public ArticleViewPage FillFrame()
        {
            WaitUntil.WaitFrame(Browser._Driver, iframe);

            inputContent.SendKeys(Messages.LoremIpsum);

            Browser._Driver.SwitchTo().DefaultContent();

            return this;
        }

        public ArticleViewPage EnterSeoInfo()
        {
            WaitUntil.WaitElement(Browser._Driver, inputSeoTitle);

            inputSeoTitle.SendKeys(Messages.LoremIpsum);
            inputSeoMetaDesc.SendKeys(Messages.LoremIpsum);
            inputSeoFocusKeyPhrase.SendKeys(Messages.InsertImg + Browser.Random.Next(0, 10000));

            return this;
        }


        public ArticleViewPage EnterFeaturedImage(string path)
        {
            WaitUntil.WaitElement(Browser._Driver, inputTitleImg);

            inputTitleImg.SendKeys(Messages.LoremIpsum);
            inputAltTextImg.SendKeys(Messages.LoremIpsum);
            inputSourceUrlImg.SendKeys(Messages.LoremIpsum);

            var boxSourceName = new SelectElement(selectSourceNameImg);
            boxSourceName.SelectByIndex(Browser.Random.Next(1, 10));

            inputImg.SendKeys(Browser.RootPath() + path);
            btnSaveMainImg.Click();

            Assert.AreEqual(GetTagModal(), "Ok!");

            btnOK.Click();

            return this;
        }

        public ArticleViewPage PressSaveAndPublish()
        {
            Browser.ScrollTop(Scripts.ScrollTop);

            WaitUntil.WaitElement(Browser._Driver, btnSaveAndPublish);
            btnSaveAndPublish.Click();

            WaitUntil.WaitSomeInterval(1);
            btnConfirmPublish.Click();
            return this;
        }

        public ArticleViewPage GetDateOfPublication()
        {
            WaitUntil.WaitElementByLocator(Browser._Driver, datePublishedAt, 60);
            string publishedAt = _datePublishedAt.Text.Trim();

            Assert.AreEqual(publishedAt, DateTime.Today.ToString("dd/MM/yyyy"));

            return this;
        }

    }
}
