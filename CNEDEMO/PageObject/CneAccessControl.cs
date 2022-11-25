using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CNEDEMO.PageObject
{
    public class CneAccessControl
    {
        IWebDriver driver;
        public CommonPage commonPage;

        public CneAccessControl(IWebDriver driver)
        {
            this.driver = driver;
        }


        

    }
}

