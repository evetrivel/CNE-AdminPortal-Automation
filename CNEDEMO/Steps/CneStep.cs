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
    public sealed class CneStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        public CommonPage commonPage;
        // public CommonSteps commonSteps;

        public CneStep(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = CommonSteps.driver;
        public CnePages CnePages;



        [When(@"verify the home page title ""(.*)""")]
        public void WhenVerifyTheHomePageTitle(string windowTitle)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            string Value = driver.Title;
            Assert.AreEqual(windowTitle , Value);
        }

        [Then(@"verify the CNE logo in home page")]
        public void ThenVerifyTheCNELogoInHomePage()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.CneLogo));
        }

        [When(@"verify the select brand drop down button exsist")]
        public void WhenVerifyTheSelectBrandDropDownButtonExsist()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.CneLogo));            
        }

        [When(@"Select select brand drop down button")]
        public void WhenSelectSelectBrandDropDownButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.SelectBrandButton);
        }



        [Then(@"verify selected brand logo in admin portal page")]
        public void ThenVerifySelectedBrandLogoInAdminPortalPage()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.BrandLogo));
        }

        [Then(@"select ""(.*)"" in the list and verify brand logo")]
        public void ThenSelectInTheListAndVerifyBrandLogo(string brand)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.BrandSelectListValue(driver, brand);
            //CommonPage.SelectFromDropDown(driver, CnePages.SelectBrandButton, brand , "SelectByText");
            Thread.Sleep(3000);
        }

        [Then(@"select ""(.*)"" in the list")]
        public void ThenSelectInTheList(string Value)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.BrandSelectListValue(driver, Value);
            Thread.Sleep(3000);
        }

        [Then(@"verify ""(.*)"" button is exists")]
        public void ThenVerifyButtonIsExists(string Value)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyListedCountryDisplayed(driver, Value));
            //CommonPage.BrandSelectListValue(driver, Value);
            Thread.Sleep(3000);
        }


        [Then(@"verify Countries in CNI channels")]
        public void ThenVerifyCountriesInCNIChannels(Table table)
        {
            for (int i = 0; i < table.Rows.Count; i++)

            {
                CnePages = new CnePages(driver);
                CommonPage commonPage = new CommonPage(driver);
                Assert.IsTrue(CommonPage.VerifyListedCountryDisplayed(driver, table.Rows[i]["Countries"]));
            }
        }

        [Then(@"verify Add New Video button exist")]
        public void ThenVerifyAddNewVideoButtonExist()
        {
             CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.NewVideoButton));
        }

        [Then(@"select Add New Video button")]
        public void ThenSelectAddNewVideoButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.NewVideoButton);
        }

        [Then(@"verify navigating into New video page")]
        public void ThenVerifyNavigatingIntoNewVideoPage()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.NewVideoPage));
        }

        [Then(@"verify Cancel and Save button exsist")]
        public void ThenVerifyCancelAndSaveButtonExsist()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.CancelButton));
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.SaveButton));
        }

        [Then(@"select O&O dropdown")]
        public void ThenSelectOODropdown()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.OAndODropDown);
        }

        [Then(@"Enter value in O&O Title")]
        public void ThenEnterValueInOOTitle(Table table)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Console.WriteLine(table.Rows[i]["O&O Title"]);              
                CommonPage.PutTextValue(driver, CnePages.OOVideoTitle, table.Rows[i]["O&O Title"]);
                
            }
        }

        [Then(@"Select O&O Categories dropdown")]
        public void ThenSelectOOCategoriesDropdown()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideoCatgory);

        }


        [Then(@"Select Slug button")]
        public void ThenSelectSlugButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.SlugButton);
        }

        [Then(@"Select Save Button")]
        public void ThenSelectSaveButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.clickableJavaElement(driver, CnePages.SaveButton);
        }

        [Then(@"verify video created succesfully")]
        public void ThenVerifyVideoCreatedSuccesfully()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.VerifyNewlyAddedVideo)); 
        }

        [Then(@"Select the cancel button")]
        public void ThenSelectTheCancelButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.CancelButton);
        }

        [Then(@"verify navigate back to home page")]
        public void ThenVerifyNavigateBackToHomePage()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.NewVideoButton));
        }

        [Then(@"Enter value in O&O tab")]
        public void ThenEnterValueInOOTab(Table table)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "O&O Title":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        CommonPage.DynamicPutTextValue(driver, CnePages.OOVideoTitle);
                       // CommonPage.PutTextValue(driver, CnePages.OOVideoTitle, table.Rows[i]["Value"]);
                        break;

                    case "O&O Categories list":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        //CommonPage.ClickableElement(driver, CnePages.VideoCatgory);
                        CommonPage.PutTextValueandSelectDropDownvalue(driver, CnePages.VideoCatgory, table.Rows[i]["Value"]);
                       // CommonPage.checkdropdownValueclick(driver, CnePages.VideoCatgory, table.Rows[i]["Value"], "SelectByValue");
                        break;

                    case "O&O Description":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        CommonPage.PutTextValue(driver, CnePages.VideoDiscription, table.Rows[i]["Value"]);
                        break;

                    case "O&O Tags":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        CommonPage.PutTextValueForTags(driver, CnePages.VidoeTag, table.Rows[i]["Value"]);
                        break;
                }
            }



        }

        [Then(@"select youtube and facebook check box")]
        public void ThenSelectYoutubeAndFacebookCheckBox()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.YoutubecheckBox);
            Thread.Sleep(3000);
            CommonPage.ClickableElement(driver, CnePages.FacebookcheckBox);
        }


        [Then(@"Enter value in youtube tab")]
        public void ThenEnterValueInYoutubeTab(Table table)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "YouTube Tags":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.PutTextValueForTags(driver, CnePages.YoutubeTags, table.Rows[i]["Value"]);
                        break;

                    case "YouTube Channel":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.YoutubeChannel);
                        //CommonPage.checkdropdownValueclick(driver, CnePages.YoutubeChannel, table.Rows[i]["Value"], "SelectByValue");
                        break;

                    case "YouTube Description":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.PutTextValue(driver, CnePages.YoutubeDescription, table.Rows[i]["Value"]);
                        break;

                    case "YouTube Category":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        //CommonPage.ClickableElement(driver, CnePages.YoutubeCategory);
                        CommonPage.checkdropdownValueclick(driver, CnePages.YoutubeCategory, table.Rows[i]["Value"], "SelectByValue");
                        break;
                }
            }

                }

        [Then(@"Enter value in Facebook tab")]
        public void ThenEnterValueInFacebookTab(Table table)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {

                switch (table.Rows[i]["input_fields"])
                {
                    case "Facebook Tags":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.PutTextValueForTags(driver, CnePages.FacebookTags, table.Rows[i]["Value"]);
                        break;
                    case "Facebook Description":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);                      
                        CommonPage.PutTextValueForTags(driver, CnePages.FacebookDescription, table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        break;
                }


            }
        }

        [Then(@"select schedule tab")]
        public void ThenSelectScheduleTab()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.ScheduleTab);
        }



        [Then(@"verify error meaasge ""(.*)""")]
        public void ThenVerifyErrorMeaasge(string Value)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyMentionedElementDisplayed(driver, CnePages.OOErrorMsg , Value));
        }

        [Then(@"select youtube tab")]
        public void ThenSelectYoutubeTab()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.YoutubeTab);
        }

        [Then(@"select Facebook tab")]
        public void ThenSelectFacebookTab()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.FacebookTab);
        }

        [Then(@"select recent video edit drop down icon")]
        public void ThenSelectRecentVideoEditDropDownIcon()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.EditButtonIcon);
        }

        [Then(@"select video media category")]
        public void ThenSelectVideoMediaCategory()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideoMedia);
        }

        [Then(@"Select O&O UploadposterFrame button")]
        public void ThenSelectOOUploadposterFrameButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.UploadOOPosterFrameButton);
        }

        [Then(@"select draganddrop  button and upload img from local")]
        public void ThenSelectDraganddropButtonAndUploadImgFromLocal()
        {
            //driver.SwitchTo().Frame("5fdbe38e7fa50b11c3b8c8dfc8d11449");
            driver.SwitchTo().ParentFrame();
            
            CnePages = new CnePages(driver);
            
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.DragandDrop);

            var processinfo = new ProcessStartInfo()
            {
                FileName = @"C:\Users\evetrivel\Downloads\File+Upload\FileUpload.exe",
                Arguments = @"C:\Users\evetrivel\Downloads\Screenshots-20220808T062405Z-001\Screenshots\testimg.png"
            };

            using (var process = Process.Start(processinfo))
            {
                process.WaitForExit();
            }


            Thread.Sleep(5000);

        }

        [Then(@"select cropimage button")]
        public void ThenSelectCropimageButton()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.CropimageButton);
            WaitHelper.WaitUntilPageLoads(driver);
        }

        [Then(@"select O&O Poster Frame dounload button and verify the download image title in next tab")]
        public void ThenSelectOOPosterFrameDounloadButtonAndVerifyTheDownloadImageTitleInNextTab()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.DownloadOOPosterFrameButton);
            var newTabHandle = driver.WindowHandles[1];
            string expectedNewWindowTitle = "acme_test123-2022-10-04-a.jpg (1920×1080)";
            Assert.AreEqual(driver.SwitchTo().Window(newTabHandle).Title.Contains("acme"), expectedNewWindowTitle.Contains("acme"));
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        [Then(@"select editcrop button")]
        public void ThenSelectEditcropButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.Editcrop);
        }

        [Then(@"verify youtube UploadposterFrame button")]
        public void ThenVerifyYoutubeUploadposterFrameButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.UploadyoutubePosterFrameButton));
        }

        [Then(@"verify OOT UploadposterFrame button")]
        public void ThenVerifyOOTUploadposterFrameButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.UploadOOTPosterFrameButton));
        }

        [Then(@"Select O&O Add Source Video button")]
        public void ThenSelectOOAddSourceVideoButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.UploadAddSourceVideoButton);
        }

        [Then(@"select draganddrop  button")]
        public void ThenSelectDraganddropButton()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            // string FilePath = "C\\Users\\evetrivel\\Downloads\\Sample_Video-20220808T062404Z-001\\Sample_Video\\video.mp4";
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideodragDrop);

            var processinfo = new ProcessStartInfo()
            {
                FileName = @"C:\Users\evetrivel\Downloads\File+Upload\FileUpload.exe",
                Arguments = @"C:\Users\evetrivel\Downloads\Sample_Video-20220808T062404Z-001\Sample_Video\video.mp4"
            };

            //processinfo.FileName = @"F:\Auto\FileUpload.exe";
            //processinfo.Arguments = @"C:\downloads\ExcelData.xlsx";

            //Process process = Process.Start(processinfo);
            //process.WaitForExit();
            //process.Close();

            using (var process = Process.Start(processinfo))
            {
                process.WaitForExit();
            }


            Thread.Sleep(5000);
        }

        [Then(@"select draganddrop  button for replace video")]
        public void ThenSelectDraganddropButtonForReplaceVideo()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            // string FilePath = "C\\Users\\evetrivel\\Downloads\\Sample_Video-20220808T062404Z-001\\Sample_Video\\video.mp4";
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideodragDrop);

            var processinfo = new ProcessStartInfo()
            {
                FileName = @"C:\Users\evetrivel\Downloads\File+Upload\FileUpload.exe",
                Arguments = @"C:\Users\evetrivel\Downloads\Sample_Video-20220808T062404Z-001\Sample_Video\video2.mp4"
            };

            //processinfo.FileName = @"F:\Auto\FileUpload.exe";
            //processinfo.Arguments = @"C:\downloads\ExcelData.xlsx";

            //Process process = Process.Start(processinfo);
            //process.WaitForExit();
            //process.Close();

            using (var process = Process.Start(processinfo))
            {
                process.WaitForExit();
            }


            Thread.Sleep(5000);
        }


        [Then(@"wait until video get uploaded")]
        public void ThenWaitUntilVideoGetUploaded()
        {
            WaitHelper.WaitUntilPageLoads(driver);
            Thread.Sleep(60000);
        }

        [Then(@"select close button")]
        public void ThenSelectCloseButton()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            Thread.Sleep(60000);
            CommonPage.ClickableElement(driver, CnePages.Closebutton);
        }

        [Then(@"select replace video button")]
        public void ThenSelectReplaceVideoButton()
        {
            CnePages = new CnePages(driver);
            
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.ReplaceVideo);
        }

        [Then(@"select replace video button in popup")]
        public void ThenSelectReplaceVideoButtonInPopup()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.Replacevideopopupbutton);
        }

        [Then(@"verify O&O Animated Thumbnail")]
        public void ThenVerifyOOAnimatedThumbnail()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Thread.Sleep(10000);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.OOAnimatedThumbnail));
        }

        [Then(@"verify O&O poster frame from thumbnails")]
        public void ThenVerifyOOPosterFrameFromThumbnails()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.OOPosterframefromthumbnails));
        }

        [Then(@"select  Externals ID category")]
        public void ThenSelectExternalsIDCategory()
        {
            CnePages = new CnePages(driver);

            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.ExternalId);
        }


        [Then(@"Enter value in youtube and FB field")]
        public void ThenEnterValueInYoutubeAndFBField(Table table)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "youtube":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.PutTextValue(driver, CnePages.YoutubeEid, table.Rows[i]["Value"]);
                        break;

                    case "Facebook":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.PutTextValue(driver, CnePages.FacebookEid, table.Rows[i]["Value"]);
                        break;

                    
                }
            }
        }


        [Then(@"Select Save button in EID")]
        public void ThenSelectSaveButtonInEID()
        {
            CnePages = new CnePages(driver);

            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.SaveEid);
        }

        [Then(@"select  Mid-roll Cue Points  category")]
        public void ThenSelectMid_RollCuePointsCategory()
        {
            CnePages = new CnePages(driver);

            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.MidrollCuePoints);
        }

        [Then(@"verify the mid-roll cue points forward button")]
        public void ThenVerifyTheMid_RollCuePointsForwardButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.MidrollCuePointsforwardbutton));
        }

        [Then(@"verify the mid-roll cue points backward button")]
        public void ThenVerifyTheMid_RollCuePointsBackwardButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.MidrollCuePointsbackwardbutton));
        }

        [Then(@"select range ms of mid-roll cue points for forward button")]
        public void ThenSelectRangeMsOfMid_RollCuePointsForForwardButton()
        {
            CnePages = new CnePages(driver);

            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.MidrollCuePointsforwardbutton);
            Thread.Sleep(2000);
            CommonPage.ClickableElement(driver, CnePages.MidrollCuePointsforwardbutton);
            Thread.Sleep(2000);
            CommonPage.ClickableElement(driver, CnePages.MidrollCuePointsforwardbutton);
        }


        [Then(@"Select save button in Mid-roll")]
        public void ThenSelectSaveButtonInMid_Roll()
        {
            CnePages = new CnePages(driver);

            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.MidrollCuePointSavebutton);
        }

        [Then(@"verify the mid-roll cue points")]
        public void ThenVerifyTheMid_RollCuePoints()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.MidrollCuePointsrecord));
        }

        [Then(@"Select delete button in Mid-roll")]
        public void ThenSelectDeleteButtonInMid_Roll()
        {
            CnePages = new CnePages(driver);

            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.MidrollCuePointdeletebutton);
            Thread.Sleep(3000);
            driver.SwitchTo().ParentFrame();


        }


        [Then(@"select range ms of mid-roll cue points for backward button")]
        public void ThenSelectRangeMsOfMid_RollCuePointsForBackwardButton()
        {
            CnePages = new CnePages(driver);

            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.MidrollCuePointsbackwardbutton);
        }


        [Then(@"select  O&O Geofencing  category")]
        public void ThenSelectOOGeofencingCategory()
        {
            CnePages = new CnePages(driver);

            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.Geofencing);
        }


        [Then(@"Select save button in O&O Geofencing")]
        public void ThenSelectSaveButtonInOOGeofencing()
        {
            CnePages = new CnePages(driver);

            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GeofencingSave);
        }

        [Then(@"Select value in Blocked In and Available In")]
        public void ThenSelectValueInBlockedInAndAvailableIn(Table table)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "Available In":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.PutTextValueandSelectDropDownvalue(driver, CnePages.Geofencingavalablein, table.Rows[i]["Value"]);
                        break;

                    case "Blocked In":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.PutTextValueandSelectDropDownvalue(driver, CnePages.Geofencingblockin, table.Rows[i]["Value"]);
                        break;


                }
            }
        }

        [Then(@"select recent video title link")]
        public void ThenSelectRecentVideoTitleLink()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideoHyperLink);
        }

        [Then(@"seelct the video log icon")]
        public void ThenSeelctTheVideoLogIcon()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideoiconrBiefcase);
        }

        [Then(@"verify the video log details")]
        public void ThenVerifyTheVideoLogDetails()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.VideoLogDetials));
        }

        [Then(@"verify error in video log details")]
        public void ThenVerifyErrorInVideoLogDetails()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsFalse(CommonPage.VerifyElementDisplayed(driver, CnePages.ErrorVideoLogDetials));
           // CnePages.error();
           // Assert.AreNotEqual("error", CnePages.getSavederror());
        }

        [Then(@"verify error in video log status details")]
        public void ThenVerifyErrorInVideoLogStatusDetails(Table table)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "Status1":
                        Console.WriteLine(table.Rows[i]["input_fields"]);                        
                        Thread.Sleep(3000);
                        Assert.AreNotEqual("error", CommonPage.GetTextValue(driver, CnePages.Error1));
                        break;
                    case "Status2":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Thread.Sleep(3000);
                        Assert.AreNotEqual("error", CommonPage.GetTextValue(driver, CnePages.Error2));
                        break;
                    case "Status3":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Thread.Sleep(3000);
                        Assert.AreNotEqual("error", CommonPage.GetTextValue(driver, CnePages.Error3));
                        break;
                    case "Status4":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Thread.Sleep(3000);
                        Assert.AreNotEqual("error", CommonPage.GetTextValue(driver, CnePages.Error4));
                        break;
                    case "Status5":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Thread.Sleep(3000);
                        Assert.AreNotEqual("error", CommonPage.GetTextValue(driver, CnePages.Error5));
                        break;
                    case "Status6":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Thread.Sleep(3000);
                        Assert.AreNotEqual("error", CommonPage.GetTextValue(driver, CnePages.Error6));
                        break;
                    case "Status7":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Thread.Sleep(3000);
                        Assert.AreNotEqual("error", CommonPage.GetTextValue(driver, CnePages.Error7));
                        break;
                }
            }
        }


        [Then(@"select the close button in log")]
        public void ThenSelectTheCloseButtonInLog()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideoLogCloseButton);
        }

        [Then(@"verify the edit icon")]
        public void ThenVerifyTheEditIcon()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.VideoLogIconEdit));
        }

        [Then(@"verify the URL link")]
        public void ThenVerifyTheURLLink()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.URLLink));
        }

        [Then(@"Select the generate button")]
        public void ThenSelectTheGenerateButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GenerateButton);
        }

        [Then(@"verify the generate preview link")]
        public void ThenVerifyTheGeneratePreviewLink()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.PreviewLink));
        }

        [Then(@"verify the delete button in generate link")]
        public void ThenVerifyTheDeleteButtonInGenerateLink()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.GeneratelinkDeleteButton));
        }

        [Then(@"verify the FB link")]
        public void ThenVerifyTheFBLink()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.FbLink));
        }

        [Then(@"verify the youtube link")]
        public void ThenVerifyTheYoutubeLink()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.youTubeLink));
        }

        [Then(@"select DOWNLOAD ENCODED VIDEO FILES")]
        public void ThenSelectDOWNLOADENCODEDVIDEOFILES(Table table)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "sourceLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.source);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                    case "highLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.high);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                    case "lowLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.low);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                    case "mobileLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.mobile);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                    case "hlsLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.hls);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                    case "O&O PosterFrameLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.DOWNLOADPOSTERFILES);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;


                }
            }
        }

        [When(@"select All brand videos")]
        public void WhenSelectAllBrandVideos()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.AllBrandVideo);
        }

        [Then(@"verify the total count of videos at bottom of the page")]
        public void ThenVerifyTheTotalCountOfVideosAtBottomOfThePage()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.TotalVideoCount));
        }

        [Then(@"select Rows per page count")]
        public void ThenSelectRowsPerPageCount()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.AllVideoRowperpage);
        }

        [Then(@"verify page count values")]
        public void ThenVerifyPageCountValues(Table table)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "10":
                        CnePages = new CnePages(driver);
                        Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.VideoperPage10));
                        break;
                    case "25":
                        CnePages = new CnePages(driver);
                        Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.VideoperPage25));
                        break;
                    case "50":
                        CnePages = new CnePages(driver);
                        Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.VideoperPage50));
                        break;
                    case "100":
                        CnePages = new CnePages(driver);
                        Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.VideoperPage100));
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.VideoperPage10);
                        break;
                }
            }
        }

        [Then(@"select the next page page button")]
        public void ThenSelectTheNextPagePageButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.NextPage);
        }

        [Then(@"select the previuos page page button")]
        public void ThenSelectThePreviuosPagePageButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.PreviousPage);
        }

        [Then(@"verify the video count")]
        public void ThenVerifyTheVideoCount()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.Videocount));
        }

        [Then(@"enter any valid video id ""(.*)"" in search box")]
        public void ThenEnterAnyValidVideoIdInSearchBox(string Value)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CnePages.VideoSearchBox, "Value");
        }

        


        [Then(@"select search  button")]
        public void ThenSelectSearchButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideoSearchButton);
        }

        [Then(@"select clear  button")]
        public void ThenSelectClearButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideoClearButton);
        }

        [Then(@"verify the results video")]
        public void ThenVerifyTheResultsVideo()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.videoResultVerify));
        }

        [When(@"select Global Localization")]
        public void WhenSelectGlobalLocalization()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalLocalization);
        }

        [Then(@"select the copy button")]
        public void ThenSelectTheCopyButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalCopy);
        }

        [Then(@"Choose destination in ""(.*)"" drop down")]
        public void ThenChooseDestinationInDropDown(string Value)
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
           // CommonPage.clickableJavaElement(driver, CnePages.GlobalSelectBrand);
            //Thread.Sleep(3000);
            //CommonPage.BrandListValue(driver, Value );
            CommonPage.SelectFromDropDown(driver, CnePages.GlobalSelectBrand, Value,"selectBy");
            
        }


        [Then(@"select exit popup")]
        public void ThenSelectExitPopup()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalPopupExit);
        }


        [Then(@"Select the select button")]
        public void ThenSelectTheSelectButton()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalSelect);
            Thread.Sleep(7000);
        }

        [Then(@"verify More button exist")]
        public void ThenVerifyMoreButtonExist()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.GlobalMoreButton));
        }

        [Then(@"Select the more button")]
        public void ThenSelectTheMoreButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalMoreButton);
        }

        [Then(@"select view detials")]
        public void ThenSelectViewDetials()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalViewDetials);
        }

        [Then(@"select Download")]
        public void ThenSelectDownload()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalVideoDownload);
        }

        [Then(@"select DOWNLOAD ENCODED VIDEO FILES in dropdown")]
        public void ThenSelectDOWNLOADENCODEDVIDEOFILESInDropdown(Table table)
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["input_fields"])
                {
                    case "sourceLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.Globalsource);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                    case "highLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.GlobalVideoDownload);
                        CommonPage.ClickableElement(driver, CnePages.Globalhigh);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                    case "lowLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        CommonPage.ClickableElement(driver, CnePages.GlobalVideoDownload);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.Globallow);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                    case "Thumbnail":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        CommonPage.ClickableElement(driver, CnePages.GlobalVideoDownload);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.GlobalThumbnail);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                    case "hlsLink":
                        Console.WriteLine(table.Rows[i]["input_fields"]);
                        Console.WriteLine(table.Rows[i]["Value"]);
                        CommonPage.ClickableElement(driver, CnePages.GlobalVideoDownload);
                        Thread.Sleep(3000);
                        CommonPage.ClickableElement(driver, CnePages.Globalhls);
                        driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        break;

                }
            }
        }

        [Then(@"select youtube in Global view detials")]
        public void ThenSelectYoutubeInGlobalViewDetials()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalYoutube);
        }

        [Then(@"select exit detials popup")]
        public void ThenSelectExitDetialsPopup()
        {
            CnePages = new CnePages(driver);
            driver.SwitchTo().ParentFrame();
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalExit);
        }

        [Then(@"enter any valid video id ""(.*)"" in Global search box")]
        public void ThenEnterAnyValidVideoIdInGlobalSearchBox(string Value)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValueForTags(driver, CnePages.GlobalvideoSearchBox, Value);
        }

        [Then(@"select search icon button")]
        public void ThenSelectSearchIconButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.GlobalSearchIcon);
        }

        [Then(@"verify the results")]
        public void ThenVerifyTheResults()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.GlobalVerifuResult));
        }

        [Then(@"verify Hidden and delete button is exsist in all videos")]
        public void ThenVerifyHiddenAndDeleteButtonIsExsistInAllVideos()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.VideoDeleteButton));
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.VideoHiddenButton));
        }

        [Then(@"select any video edit drop down button")]
        public void ThenSelectAnyVideoEditDropDownButton()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CnePages.VideoEditButtonDrepdown);
        }


        [Then(@"verify ""(.*)""")]
        public void ThenVerify(string value)
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.VideoEditSelectListValue(driver, value);          
            Thread.Sleep(5000);
        }

        [Then(@"verify navigation video editing page")]
        public void ThenVerifyNavigationVideoEditingPage()
        {
            CnePages = new CnePages(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CnePages.BrandLogo));
        }


    }
}
