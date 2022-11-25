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
    public sealed class CneAdvertisingsteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        public CommonPage commonPage;
        // public CommonSteps commonSteps;

        public CneAdvertisingsteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = CommonSteps.driver;
        public CneAdvertisingsPage CneAdvertisingsPage;

        [When(@"select ADVERTISING lists in left side window of homepage")]
        public void WhenSelectADVERTISINGListsInLeftSideWindowOfHomepage()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.Advertising);
        }

        [Then(@"Enter creative name ""(.*)""")]
        public void ThenEnterCreativeName(string Value)
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneAdvertisingsPage.SearchBox, "Value");
        }

        [Then(@"select search  button in creative")]
        public void ThenSelectSearchButtonInCreative()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.Search);
        }

        [Then(@"select clear button in creative")]
        public void ThenSelectClearButtonInCreative()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.Clear);
        }

        [Then(@"select Add new creative button")]
        public void ThenSelectAddNewCreativeButton()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.AddnewCreate);
        }

        [Then(@"select create creative button")]
        public void ThenSelectCreateCreativeButton()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.CreateCreative);
        }

        [Then(@"verify creative error msg")]
        public void ThenVerifyCreativeErrorMsg()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneAdvertisingsPage.ErrorMSg));
        }

        [Then(@"select cancel button")]
        public void ThenSelectCancelButton()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.Cancel);
        }

        [Then(@"select Editmidea button")]
        public void ThenSelectEditmideaButton()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.EditMedia);
        }

        [Then(@"verify upload image file")]
        public void ThenVerifyUploadImageFile()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneAdvertisingsPage.Uploadimage));
        }

        [Then(@"select leave page button")]
        public void ThenSelectLeavePageButton()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.LeavePageViewallAdd);
        }

        [Then(@"select recent Add link")]
        public void ThenSelectRecentAddLink()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.AdvertisingLink);
        }

        [Then(@"select Mideo URl")]
        public void ThenSelectMideoURl()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.MediaUrl);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }


    }
}
