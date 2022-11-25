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
    public sealed class CneBrandSettingSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        public CommonPage commonPage;
        // public CommonSteps commonSteps;

        public CneBrandSettingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = CommonSteps.driver;
        public CneBrandSettingsPage CneBrandSettingsPage;

        [When(@"select YouTube Channels in left side window of homepage")]
        public void WhenSelectYouTubeChannelsInLeftSideWindowOfHomepage()
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandSettingsPage.YouTubeChannel);
        }

        [When(@"select Facebook Pages in left side window of homepage")]
        public void WhenSelectFacebookPagesInLeftSideWindowOfHomepage()
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandSettingsPage.faceBookPage);
        }

        [Then(@"select the Add YouTube Channels button")]
        public void ThenSelectTheAddYouTubeChannelsButton()
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandSettingsPage.AddNewYouTubeChannelButton);
        }

        [Then(@"select the Add Facebook Pages button")]
        public void ThenSelectTheAddFacebookPagesButton()
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandSettingsPage.AddNewFbPageButton);
        }

        [Then(@"enter value in ""(.*)"" Channel name")]
        public void ThenEnterValueInChannelName(string Value)
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandSettingsPage.ChannelName, Value);
        }

        [Then(@"enter value in ""(.*)"" channel id")]
        public void ThenEnterValueInChannelId(string Value)
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandSettingsPage.ChannelId, Value);
        }

        [Then(@"enter value in ""(.*)"" Owner id")]
        public void ThenEnterValueInOwnerId(string Value)
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandSettingsPage.ChannelOwnerId, Value);
        }

        [Then(@"select the save button")]
        public void ThenSelectTheSaveButton()
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandSettingsPage.SaveButton);
        }

        [Then(@"enter value in ""(.*)"" page name")]
        public void ThenEnterValueInPageName(string Value)
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandSettingsPage.FbPageName, Value);
        }

        [Then(@"enter value in ""(.*)"" page id")]
        public void ThenEnterValueInPageId(string Value)
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandSettingsPage.FbPageId, Value);
        }

        [Then(@"Verify the error msg in YT page ""(.*)""")]
        public void ThenVerifyTheErrorMsgInYTPage(string Value)
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            if (Value.Contains("eni"))
            {
                Thread.Sleep(3000);
            }
            else
            {
                Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandSettingsPage.YTErrormsg));
            }
        }

        [Then(@"Verify the error msg in Fb page ""(.*)""")]
        public void ThenVerifyTheErrorMsgInFbPage(string Value)
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            if (Value.Contains("eni"))
            {
                Thread.Sleep(3000);
            }
            else
            {
                Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandSettingsPage.FbErrormsg));
            }
        }

        [Then(@"select the delete button")]
        public void ThenSelectTheDeleteButton()
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            
            CommonPage.ClickableElement(driver, CneBrandSettingsPage.DeleteButton);
            Thread.Sleep(2000);
            driver.SwitchTo().ParentFrame();
            CommonPage.ClickableElement(driver, CneBrandSettingsPage.IframeDeleteButton);

        }

        [Then(@"select any Brand YouTube Channels title in the list of YouTube Channels")]
        public void ThenSelectAnyBrandYouTubeChannelsTitleInTheListOfYouTubeChannels()
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandSettingsPage.NewlyAddedYTchannel);
        }

        [Then(@"select any Brand Facebook Pages title in the list of Facebook Pages")]
        public void ThenSelectAnyBrandFacebookPagesTitleInTheListOfFacebookPages()
        {
            CneBrandSettingsPage = new CneBrandSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandSettingsPage.NewlyAddedFbChannel);
        }



    }
}
