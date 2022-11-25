using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CNEDEMO.PageObject
{
    public class CnePlayerSettingsPage
    {
        IWebDriver driver;
        public CommonPage commonPage;

        public CnePlayerSettingsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Blacklist = "//div[@class = 'cn-body container-fluid']//a[text()='Blacklist Sites']";
        public string DomainToBlock = "//div[@class = 'span10 cn-page-content']//input[@id='blacklist_site_domain']";
        public string AddtoBlocklist = "//div[@class = 'span10 cn-page-content']//input[@name='commit']";
        public string Delete = "(//div[@class = 'span10 cn-page-content']//tr//a[text()='Delete'])[1]";
        public string DeleteOk = "//button[text()='Delete']";




    }
}

