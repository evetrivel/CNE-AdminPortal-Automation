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
    public sealed class CneGlobalSettingSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        public CommonPage commonPage;
        // public CommonSteps commonSteps;

        public CneGlobalSettingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = CommonSteps.driver;
        public CneGlobalSettingsPage CneGlobalSettingsPage;

        [When(@"select Gobal settings brands in left side window of homepage")]
        public void WhenSelectGobalSettingsBrandsInLeftSideWindowOfHomepage()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneGlobalSettingsPage.Brands);
        }

        [When(@"select Gobal settings Configuration in left side window of homepage")]
        public void WhenSelectGobalSettingsConfigurationInLeftSideWindowOfHomepage()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneGlobalSettingsPage.Configuration);
        }

        [When(@"select Gobal settings Content Libraries in left side window of homepage")]
        public void WhenSelectGobalSettingsContentLibrariesInLeftSideWindowOfHomepage()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneGlobalSettingsPage.ContentLibraries);
        }

        [When(@"select Gobal settings Top Level Categories in left side window of homepage")]
        public void WhenSelectGobalSettingsTopLevelCategoriesInLeftSideWindowOfHomepage()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneGlobalSettingsPage.TopLevelCategories);
        }

        [Then(@"verify Submit button exsist")]
        public void ThenVerifySubmitButtonExsist()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneGlobalSettingsPage.ConfigSubmitButton));
        }

        [Then(@"verify the Gobal settings Configuration page")]
        public void ThenVerifyTheGobalSettingsConfigurationPage()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneGlobalSettingsPage.ConfigPageTitle));
        }

        [Then(@"verify env_URL link are working")]
        public void ThenVerifyEnv_URLLinkAreWorking(Table table)
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "Production":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        
                        CommonPage.ClickableElement(driver, CneGlobalSettingsPage.Production);
                        Thread.Sleep(3000);
                        driver.Navigate().Back();
                        Thread.Sleep(3000);
                        break;
                    case "Staging":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        
                        CommonPage.ClickableElement(driver, CneGlobalSettingsPage.Staging);
                        Thread.Sleep(3000);
                        driver.Navigate().Back();
                        Thread.Sleep(3000);
                        break;
                    case "Sandbox":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        
                        CommonPage.ClickableElement(driver, CneGlobalSettingsPage.Sandbox);
                        Thread.Sleep(3000);
                        driver.Navigate().Back();
                        Thread.Sleep(3000);
                        break;
                    case "Portal Settings":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        
                        CommonPage.ClickableElement(driver, CneGlobalSettingsPage.Portalsettings);
                        Thread.Sleep(3000);
                        driver.Navigate().Back();
                        break;

                }


            }


        }

        [Then(@"select any brand title")]
        public void ThenSelectAnyBrandTitle()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneGlobalSettingsPage.AcmeTestBrandLink);
        }

        [Then(@"verify its naviagting into Edit Brand page")]
        public void ThenVerifyItsNaviagtingIntoEditBrandPage()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneGlobalSettingsPage.AcmeBrandPageTitle));
        }

        [Then(@"verify the save button exsist")]
        public void ThenVerifyTheSaveButtonExsist()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneGlobalSettingsPage.BrandSaveButton));
        }

        [Then(@"Select the Gobal settings Content Libraries")]
        public void ThenSelectTheGobalSettingsContentLibraries()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneGlobalSettingsPage.NewContentLib);
        }

        [Then(@"Enter  value in name")]
        public void ThenEnterValueInName(Table table)
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "":
                        Console.WriteLine(table.Rows[i]["input_fields"]);

                        CommonPage.PutTextValue(driver, CneGlobalSettingsPage.Name, table.Rows[i]["input_fields"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CneGlobalSettingsPage.ContentSaveButton);
                        Thread.Sleep(3000);
                        Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneGlobalSettingsPage.ContentErrormsg));
                        break;
                    case "ATest":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Thread.Sleep(3000);
                        CommonPage.PutTextValue(driver, CneGlobalSettingsPage.Name, table.Rows[i]["input_fields"]);

                        break;

                }
            }
        }

        [Then(@"Enter ""(.*)"" value in Approvedby")]
        public void ThenEnterValueInApprovedby(string Value)
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneGlobalSettingsPage.Approvedby, Value);
        }

        [Then(@"Select ""(.*)"" value")]
        public void ThenSelectValue(string Value)
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ContentSelectListValue(driver, Value);
        }

        [Then(@"select the save button Content")]
        public void ThenSelectTheSaveButtonContent()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneGlobalSettingsPage.ContentSaveButton);
        }

        [Then(@"select edit button recent")]
        public void ThenSelectEditButtonRecent()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneGlobalSettingsPage.ContentSaveButton);
        }

        [Then(@"Verify save order button")]
        public void ThenVerifySaveOrderButton()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneGlobalSettingsPage.SaveOrder));
        }

        [Then(@"verify the save button")]
        public void ThenVerifyTheSaveButton()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneGlobalSettingsPage.topSaveButton));
        }

        [Then(@"select the edit button")]
        public void ThenSelectTheEditButton()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneGlobalSettingsPage.topEdit);
        }

        [Then(@"verify Edit CNE Category fields are editable")]
        public void ThenVerifyEditCNECategoryFieldsAreEditable()
        {
            CneGlobalSettingsPage = new CneGlobalSettingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneGlobalSettingsPage.TopCatgryTitle));
        }



    }
}
