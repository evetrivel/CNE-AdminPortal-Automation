using CNEDEMO.Helpers;
using CNEDEMO.PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CNEDEMO.Steps
{
    [Binding]
    public sealed class CneToolStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        public CommonPage commonPage;
        // public CommonSteps commonSteps;

        public CneToolStep(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = CommonSteps.driver;
        public CneToolsPage CneToolsPage;

        [When(@"select Report lists in left side window of homepage")]
        public void WhenSelectReportListsInLeftSideWindowOfHomepage()
        {
            CneToolsPage = new CneToolsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneToolsPage.Reports);
        }

        [Then(@"Select csv")]
        public void ThenSelectCsv()
        {
            CneToolsPage = new CneToolsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneToolsPage.CSV);
        }

        [Then(@"select Link")]
        public void ThenSelectLink()
        {
            CneToolsPage = new CneToolsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneToolsPage.Link);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }





    }
}
