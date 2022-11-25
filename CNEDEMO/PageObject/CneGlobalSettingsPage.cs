using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CNEDEMO.PageObject
{
    public class CneGlobalSettingsPage
    {
        IWebDriver driver;
        public CommonPage commonPage;

        public CneGlobalSettingsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Brands = "//div[@class = 'cn-body container-fluid']//a[text()='Brands']";
        public string Configuration = "//div[@class = 'cn-body container-fluid']//a[text()='Configuration']";
        public string ContentLibraries = "//div[@class = 'cn-body container-fluid']//a[text()='Content Libraries']";
        public string TopLevelCategories = "//div[@class = 'cn-body container-fluid']//a[text()='Top Level Categories']";
        public string ConfigSubmitButton = "//div[@class = 'cn-body container-fluid']//button[text()='Submit']";
        public string ConfigPageTitle = "//div[@class = 'cn-body container-fluid']//h2[text()='Configuration']";
        public string AcmeTestBrandLink = "//div[@class = 'span10 cn-page-content']//tr//a[text()='Acme Test Brand']";
        public string Production = "(//div[@class = 'span10 cn-page-content']//tr//a[text()='Production'])[1]";
        public string Staging = "(//div[@class = 'span10 cn-page-content']//tr//a[text()='Staging'])[1]";
        public string Sandbox = "(//div[@class = 'span10 cn-page-content']//tr//a[text()='Sandbox'])[1]";
        public string Portalsettings = "(//div[@class = 'span10 cn-page-content']//tr//a[text()='Portal Settings'])[1]";
        public string BrandSaveButton = "//div[@class = 'span10 cn-page-content']//button[text()='Save']";
        public string NewContentLib = "//div[@class = 'span10 cn-page-content']//a[text()='New Content Library']";
        public string AcmeBrandPageTitle = "//div[@class = 'cn-body container-fluid']//h3[text()='Edit Brand: Acme Test Brand']";
        public string Name = "//div[@class = 'span10 cn-page-content']//input[@id='content_library_name']";
        public string Approvedby = "//div[@class = 'span10 cn-page-content']//input[@id='content_library_approved_by']";
        public string ContentTypeAudio = "//div[@class = 'span10 cn-page-content']//select[@id='content_library_content_type']//*[text()='audio']";
        public string ContentTypeImage = "//div[@class = 'span10 cn-page-content']//select[@id='content_library_content_type']//*[text()='image']";
        public string ContentTypeVideo = "//div[@class = 'span10 cn-page-content']//select[@id='content_library_content_type']//*[text()='video']";
        public string ContentSaveButton = "//div[@class = 'span10 cn-page-content']//input[@name='commit']";
        public string ContentErrormsg = "//div[@class = 'span10 cn-page-content']//*[text()='Please review the problems below:']";
        public string SaveOrder = "//div[@class = 'span10 cn-page-content']//*[text()='Save Order']";
        public string topSaveButton = "//div[@class = 'span10 cn-page-content']//button[text()='Save']";
        public string topEdit = "//div[@class = 'span10 cn-page-content']//li[@data-cne-category-id='52586f8b4ffb608d95000005']//a[text()='Edit']";
        public string TopCatgryTitle = "//div[@class = 'span10 cn-page-content']//h3[text()='Edit CNE Category']";

    }
}

