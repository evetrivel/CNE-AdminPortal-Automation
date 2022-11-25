using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CNEDEMO.Helpers;
using CNEDEMO.PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace CNEDEMO.Steps
{
    [Binding]
    public sealed class CommonSteps
    {
        public static IWebDriver driver { get; set; }
        public CommonPage commonPage;
        public CnePages cnePages;

        [BeforeTestRun]
        public static void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);

            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-blink-features");
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--profile-directory=Default");
            options.AddArgument("--disable-plugins-discovery");
            options.AddArgument("no-sandbox");
            options.AddArgument("disable-gpu");
            options.AddExcludedArgument("enable-automation");
            // options.AddAdditionalCapability("useAutomationExtension", false);

            driver = new ChromeDriver(options);
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterTestRun]
        public static void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }

        [Given(@"CNE admin portal page loaded succesfully")]
        public void GivenCNEAdminPortalPageLoadedSuccesfully()
        {
            driver.Navigate().GoToUrl(ConfigHelper.GetBaseCneUrl());

            WaitHelper.WaitUntilPageLoads(driver);
            commonPage = new CommonPage(driver);
        }




        [When(@"enter username ""(.*)"" and select Next button")]
        public void WhenEnterUsernameAndSelectNextButton(string value)
        {
            WaitHelper.WaitUntilPageLoads(driver);
            cnePages = new CnePages(driver);
            commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, cnePages.UserNameTextBox, value);
            CommonPage.ClickableElement(driver, cnePages.NextButton);
        }

        [Then(@"enter password ""(.*)"" and select signIn Button to login page")]
        public void ThenEnterPasswordAndSelectSignInButtonToLoginPage(string value)
        {

            WaitHelper.WaitUntilPageLoads(driver);
            cnePages = new CnePages(driver);
            commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, cnePages.PassowrdTextBox, value);
            CommonPage.ClickableElement(driver, cnePages.SigninButton);
        }

        [Then(@"select SendPush button")]
        public void ThenSelectSendPushButton()
        {
            WaitHelper.WaitUntilPageLoads(driver);
            cnePages = new CnePages(driver);
            commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, cnePages.SendPush);
        }


        [Then(@"verify page is navigated into Admin portal homepage")]
        public void ThenVerifyPageIsNavigatedIntoAdminPortalHomepage()
        {
            Thread.Sleep(40000);
        }


    }
}
