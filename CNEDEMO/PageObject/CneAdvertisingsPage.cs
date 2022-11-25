using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CNEDEMO.PageObject
{
    public class CneAdvertisingsPage
    {
        IWebDriver driver;
        public CommonPage commonPage;

        public CneAdvertisingsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Advertising = "//div[@class = 'cn-body container-fluid']//a[text()='Ad Creatives']";
        public string SearchBox = "//div[@class = 'cn-body container-fluid']//input[@id='search-input']";
        public string Search = "(//div[@class = 'cn-body container-fluid']//input[@name='submit'])[1]";
        public string Clear = "(//div[@class = 'cn-body container-fluid']//input[@name='submit'])[2]";
        public string AddnewCreate = "//div[@class = 'cn-body container-fluid']//a[text()='Add New Creative']";
        public string EditMedia = "(//div[@class = 'cn-body container-fluid']//a[text()='Edit Media'])[1]";
        public string CreateCreative = "//div[@class = 'cn-body container-fluid']//input[@name='commit']";
        public string Cancel = "//div[@class = 'cn-body container-fluid']//a[text()='Cancel']";
        public string AdvertisingLink = "//div[@class = 'cn-body container-fluid']//a[text()='BMWlogo']";
        public string MediaUrl = "//div[@class = 'cn-body container-fluid']//div[@id='5d2f55f642b5f01cdf425031-url-panel']//p/a";
        public string Uploadimage = "//div[@class = 'cn-body container-fluid']//span[text()='Upload a Image File']";
        public string LeavePageViewallAdd = "//div[@class = 'cn-body container-fluid']//a[text()='View all ad creatives']";
        public string ErrorMSg = "//div[@class = 'cn-body container-fluid']//div[@id='error_explanation']/h2";

    }
}

