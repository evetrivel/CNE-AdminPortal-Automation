using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CNEDEMO.PageObject
{
    public class CneToolsPage
    {
        IWebDriver driver;
        public CommonPage commonPage;

        public CneToolsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Reports = "//div[@class = 'cn-body container-fluid']//a[text()='Reports']";
        public string CSV = "(//div[@class = 'cn-body container-fluid']//a[text()='CSV'])[1]";
        public string Link = "(//div[@class = 'cn-body container-fluid']//a[text()='Link'])[1]";

    }
}

