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
    public sealed class CnePlayerSettingStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        public CommonPage commonPage;
        // public CommonSteps commonSteps;

        public CnePlayerSettingStep(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = CommonSteps.driver;
        public CnePlayerSettingsPage CnePlayerSettingsPage;

        [When(@"select Player settings Blacklist Sites in left side window of homepage")]
        public void WhenSelectPlayerSettingsBlacklistSitesInLeftSideWindowOfHomepage()
        {
            CnePlayerSettingsPage = new CnePlayerSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePlayerSettingsPage.Blacklist);
        }
        [Then(@"Enter ""(.*)"" value in domain")]
        public void ThenEnterValueInDomain(string Value)
        {
            CnePlayerSettingsPage = new CnePlayerSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CnePlayerSettingsPage.DomainToBlock, Value);
        }


        [Then(@"Select Add blacklist site button exsist")]
        public void ThenSelectAddBlacklistSiteButtonExsist()
        {
            CnePlayerSettingsPage = new CnePlayerSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePlayerSettingsPage.AddtoBlocklist);
        }

        [Then(@"Select delete button in Blacklist")]
        public void ThenSelectDeleteButtonInBlacklist()
        {
            CnePlayerSettingsPage = new CnePlayerSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePlayerSettingsPage.Delete);
        }

        [Then(@"Select delete ok button")]
        public void ThenSelectDeleteOkButton()
        {
            CnePlayerSettingsPage = new CnePlayerSettingsPage(driver);
            
            CommonPage commonPage = new CommonPage(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage.ClickableElement(driver, CnePlayerSettingsPage.DeleteOk);
        }


    }
}
