using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiattaformaAutomatization.WebElements
{
    public class ArticleViewElements
    {
        [FindsBy(How = How.Id, Using = "title")]
        protected IWebElement inputTopic;

        [FindsBy(How = How.Id, Using = "HomePageTitle")]
        protected IWebElement inputHomePageTitle;

        [FindsBy(How = How.Id, Using = "AltTitle")]
        protected IWebElement inputAltTitle;

        [FindsBy(How = How.Id, Using = "Summary")]
        protected IWebElement inputSummary;

        [FindsBy(How = How.XPath, Using = "//select[@id='cat-selector']")]
        protected IWebElement selectCategory;

        [FindsBy(How = How.Id, Using = "Tag")]
        protected IWebElement inputTag;

        [FindsBy(How = How.Id, Using = "btnAddTag")]
        protected IWebElement btnAddTag;

        [FindsBy(How = How.Id, Using = "SeoTitle")]
        protected IWebElement inputSeoTitle;

        [FindsBy(How = How.Id, Using = "SeoMetaDesc")]
        protected IWebElement inputSeoMetaDesc;

        [FindsBy(How = How.Id, Using = "SeoSlug")]
        protected IWebElement inputSeoSlug;

        [FindsBy(How = How.Id, Using = "SeoFocusKeyPhrase")]
        protected IWebElement inputSeoFocusKeyPhrase;

        [FindsBy(How = How.Id, Using = "TitleImg")]
        protected IWebElement inputTitleImg;

        [FindsBy(How = How.Id, Using = "SourceUrlImg")]
        protected IWebElement inputSourceUrlImg;

        [FindsBy(How = How.Id, Using = "SourceNameImg")]
        protected IWebElement selectSourceNameImg;

        [FindsBy(How = How.Id, Using = "AltTextImg")]
        protected IWebElement inputAltTextImg;

        [FindsBy(How = How.Id, Using = "MainImg")]
        protected IWebElement inputImg;

        [FindsBy(How = How.Id, Using = "btnSaveMainImg")]
        protected IWebElement btnSaveMainImg;


        // Frame
        protected readonly By iframe = By.Id("summernote-content_ifr");

        [FindsBy(How = How.Id, Using = "tinymce")]
        protected IWebElement inputContent;




        // Modals
        [FindsBy(How = How.Id, Using = "swal2-title")]
        protected IWebElement modalOk;

        [FindsBy(How = How.XPath, Using = "//button[text()='OK']")]
        protected IWebElement btnOK;



        // Insert image in the content TinyMCE
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Insert image']")]
        protected IWebElement btnInsertImg;

        [FindsBy(How = How.Id, Using = "ModalTitleImg")]
        protected IWebElement inputModalTitleImg;

        [FindsBy(How = How.Id, Using = "ModalAltTextImg")]
        protected IWebElement inputModalAltTextImg;

        [FindsBy(How = How.Id, Using = "ModalCaptionImg")]
        protected IWebElement inputModalCaptionImg;

        [FindsBy(How = How.Id, Using = "ModalDescriptionImg")]
        protected IWebElement inputModalDescriptionImg;

        [FindsBy(How = How.Id, Using = "ModalSourceNameImg")]
        protected IWebElement selectModalSourceNameImg;

        [FindsBy(How = How.Id, Using = "ModalSourceUrlImg")]
        protected IWebElement inputModalSourceUrlImg;

        [FindsBy(How = How.Id, Using = "ModalAlignImg")]
        protected IWebElement selectModalAlignImg;

        [FindsBy(How = How.Id, Using = "ModalLinkToImg")]
        protected IWebElement selectModalLinkToImg;

        [FindsBy(How = How.Id, Using = "ModalDimensionImg")]
        protected IWebElement selectModalDimensionImg;

        [FindsBy(How = How.Id, Using = "ModalImg")]
        protected IWebElement inputModalImg;

        [FindsBy(How = How.XPath, Using = "//div[@id='modalAddImage']/div/div/div[3]/button")]
        protected IWebElement btnAddImage;



        // Insert link in the content TinyMCE
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Insert/edit link']")]
        protected IWebElement btnAddInnerLink;

        [FindsBy(How = How.XPath, Using = "//input[@type='url']")]
        protected IWebElement inputUrl;

        [FindsBy(How = How.XPath, Using = "//label[text()='Title']/parent::div/input[@type='text'][@class='tox-textfield']")]
        protected IWebElement inputTitleLink;

        [FindsBy(How = How.XPath, Using = "//button[@title='Save']")]
        protected IWebElement btnSaveLink;


        protected readonly By iFrame = By.Id("summernote-content_ifr");


        // Buttons
        [FindsBy(How = How.XPath, Using = "//a[@data-target='#modalPublishTitle']")]
        protected IWebElement btnSaveAndPublish;

        [FindsBy(How = How.Id, Using = "btnPublish")]
        protected IWebElement btnConfirmPublish;


        // Info about article
        protected readonly By datePublishedAt = By.XPath("//span[@class='writing-date']/span[2]/strong");
        protected IWebElement _datePublishedAt => Browser._Driver.FindElement(datePublishedAt);
    }
}
