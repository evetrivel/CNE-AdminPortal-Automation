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
    public sealed class CneBrandEditorialSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        public CommonPage commonPage;
        // public CommonSteps commonSteps;

        public CneBrandEditorialSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = CommonSteps.driver;
        public CneBrandEditorialPage CneBrandEditorialPage;

        [When(@"select Series&season in left side window of homepage")]
        public void WhenSelectSeriesSeasonInLeftSideWindowOfHomepage()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.SerieAndSeasons);
        }

        [Then(@"verify Save order button exist")]
        public void ThenVerifySaveOrderButtonExist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.SaveOrder));
        }

        [Then(@"select Add New Series button")]
        public void ThenSelectAddNewSeriesButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.AddNewSeries);
        }

        [Then(@"verify navigating into New Series detials data page")]
        public void ThenVerifyNavigatingIntoNewSeriesDetialsDataPage()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            //Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.TitleNewSeries));
        }


        [Then(@"Enter value in ""(.*)"" in new series")]
        public void ThenEnterValueInInNewSeries(string Value)
        {
            if (Value.Contains("TestReg"))
            {
                CneBrandEditorialPage = new CneBrandEditorialPage(driver);
                CommonPage commonPage = new CommonPage(driver);
                CommonPage.DynamicPutTextValue(driver, CneBrandEditorialPage.TitleNewSeries);
                //CommonPage.PutTextValue(driver, CneBrandEditorialPage.TitleNewSeries, Value);
            }
            else {
                CneBrandEditorialPage = new CneBrandEditorialPage(driver);
                CommonPage commonPage = new CommonPage(driver);
                CommonPage.PutTextValue(driver, CneBrandEditorialPage.TitleNewSeries, Value);
               // CommonPage.DynamicPutTextValue(driver, CneBrandEditorialPage.TitleNewSeries);
            }
            
            //
        }


        [Then(@"select create button")]
        public void ThenSelectCreateButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.CreateSeriesButton);
        }

        [Then(@"verify created Season is exsist")]
        public void ThenVerifyCreatedSeasonIsExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.Season1));
        }




        [Then(@"Enter value in SeriesCategories ""(.*)"" in seriespage")]
        public void ThenEnterValueInSeriesCategoriesInSeriespage(string Value)
        {

            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandEditorialPage.SeriesCategories, Value);
        }


        [Then(@"select update button")]
        public void ThenSelectUpdateButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.UpdateSeriesButton);
        }

        [Then(@"verify error msg")]
        public void ThenVerifyErrorMsg()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.InvalidInputErrorMsg));
        }

        [Then(@"Select save order Button")]
        public void ThenSelectSaveOrderButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
           CommonPage.ClickableElement(driver, CneBrandEditorialPage.SaveOrder);
            Thread.Sleep(3000);
           driver.SwitchTo().Alert().Accept();
        }

        [Then(@"Rearrange the order in Series list by drag and drop")]
        public void ThenRearrangeTheOrderInSeriesListByDragAndDrop()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
        }


        [Then(@"verify save order buttton")]
        public void ThenVerifySaveOrderButtton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.SaveOrder));
        }

        [Then(@"select edit series or Title of the series")]
        public void ThenSelectEditSeriesOrTitleOfTheSeries()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.NewSeriesEditButton);
        }

        [Then(@"select Add season button")]
        public void ThenSelectAddSeasonButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.AddSeason);
        }

        [Then(@"enter basic season title ""(.*)"" value")]
        public void ThenEnterBasicSeasonTitleValue(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandEditorialPage.BasicSeasonTitle, Value);
        }

        [Then(@"select upload poster frame")]
        public void ThenSelectUploadPosterFrame()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            //CommonPage.clickableJavaElement(driver, CneBrandEditorialPage.SelectImageToUpload1);
            //Thread.Sleep(2000);
           // driver.SwitchTo().ParentFrame(); //need to check this upload popup window

           // var processinfo = new ProcessStartInfo()
           // {
           //     FileName = @"C:\Users\evetrivel\Downloads\File+Upload\FileUpload.exe",
            //    Arguments = @"C:\Users\evetrivel\Downloads\Screenshots-20220808T062405Z-001\Screenshots\frame.jpg"
            //};

          //  using (var process = Process.Start(processinfo))
           // {
           //     process.WaitForExit();
           // }


           // Thread.Sleep(5000);

        }


        [Then(@"select upload title image")]
        public void ThenSelectUploadTitleImage()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.clickableJavaElement(driver, CneBrandEditorialPage.SelectImageToUpload2);
            Thread.Sleep(2000);
            driver.SwitchTo().ParentFrame(); //need to check this upload popup window

            var processinfo = new ProcessStartInfo()
            {
                FileName = @"C:\Users\evetrivel\Downloads\File+Upload\FileUpload.exe",
                Arguments = @"C:\Users\evetrivel\Downloads\Screenshots-20220808T062405Z-001\Screenshots\title.jpg"
            };

            using (var process = Process.Start(processinfo))
            {
                process.WaitForExit();
            }


            Thread.Sleep(5000);

        }

        [Then(@"verify basic create button")]
        public void ThenVerifyBasicCreateButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
           // Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.BasicCreateSeasonButton));
        }

        [Then(@"select host catagory")]
        public void ThenSelectHostCatagory()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.HostButton);
        }

        [Then(@"enter host title ""(.*)"" value")]
        public void ThenEnterHostTitleValue(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValueNextTab(driver, CneBrandEditorialPage.HostTitle, Value);
        }

        [Then(@"select hostintro value in dropdown")]
        public void ThenSelectHostintroValueInDropdown()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.HostIntro);
        }

        [Then(@"select upload hostimage")]
        public void ThenSelectUploadHostimage()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
           // CommonPage.ClickableElement(driver, CneBrandEditorialPage.HostImageselectuploadbutton);
          //  Thread.Sleep(2000);
          //  driver.SwitchTo().ParentFrame(); //need to check this upload popup window

          //  var processinfo = new ProcessStartInfo()
          //  {
          //      FileName = @"C:\Users\evetrivel\Downloads\File+Upload\FileUpload.exe",
          //      Arguments = @"C:\Users\evetrivel\Downloads\Screenshots-20220808T062405Z-001\Screenshots\frame-500.jpg"
          //  };

          //  using (var process = Process.Start(processinfo))
          //  {
          //      process.WaitForExit();
          //  }


          //  Thread.Sleep(5000);
        }

        [Then(@"verify host create button")]
        public void ThenVerifyHostCreateButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.HostCreateSeasonButton));
        }

        [Then(@"verify credit create button")]
        public void ThenVerifyCreditCreateButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.CreditCreateSeasonButton));
        }



        [Then(@"select credit create button")]
        public void ThenSelectCreditCreateButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.CreditCreateSeasonButton);
            Thread.Sleep(3000);
        }


        [Then(@"verify episode create button")]
        public void ThenVerifyEpisodeCreateButton()
        {
            WaitHelper.WaitUntilPageLoads(driver);
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.EpiOrderingCreateSeasonButton));
        }


        [Then(@"select credit catagory")]
        public void ThenSelectCreditCatagory()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.CreditsButton);
        }


        [Then(@"select episodes catagory")]
        public void ThenSelectEpisodesCatagory()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);           
            CommonPage.scrollUp(driver, CneBrandEditorialPage.EpisodeOrderingButton);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.EpisodeOrderingButton);
        }

        [Then(@"enter maincredits name ""(.*)"" value")]
        public void ThenEnterMaincreditsNameValue(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandEditorialPage.MainCreditName, Value);
        }

        [Then(@"enter Featured credits name ""(.*)"" value")]
        public void ThenEnterFeaturedCreditsNameValue(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandEditorialPage.FeaturedcreditName, Value);
        }


        [Then(@"enter directorcredits name ""(.*)"" value")]
        public void ThenEnterDirectorcreditsNameValue(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandEditorialPage.DirectorCreditName, Value);
        }

        [Then(@"enter productioncredits name ""(.*)"" value")]
        public void ThenEnterProductioncreditsNameValue(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandEditorialPage.ProductionCreditName, Value);
        }
        [Then(@"enter videorgrapher ""(.*)"" value")]
        public void ThenEnterVideorgrapherValue(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandEditorialPage.VideoGrapherCreditName, Value);
        }


        [Then(@"enter legalcredits name ""(.*)"" value")]
        public void ThenEnterLegalcreditsNameValue(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValue(driver, CneBrandEditorialPage.LegalCredits, Value);
        }


        [Then(@"select maincredits celebrity value in dropdown")]
        public void ThenSelectMaincreditsCelebrityValueInDropdown()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.MainCreditCelebrityTypeDropdown);
        }

        [Then(@"select Featured credits celebrity value in dropdown")]
        public void ThenSelectFeaturedCreditsCelebrityValueInDropdown()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.FeaturedcreditCelebrityTypeDropdown);
        }

        [Then(@"select productioncredits productionrole value in dropdown")]
        public void ThenSelectProductioncreditsProductionroleValueInDropdown()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.ProductionCreditProductionroleDropdown);
        }


        [Then(@"select directorcredits celebrity value in dropdown")]
        public void ThenSelectDirectorcreditsCelebrityValueInDropdown()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.DirectorCreditCelebrityTypeDropdown);
        }

        [Then(@"select maincredits addnew button")]
        public void ThenSelectMaincreditsAddnewButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.MainCreditAddnewButton);
        }

        [Then(@"select Featured credits addnew button")]
        public void ThenSelectFeaturedCreditsAddnewButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.FeaturedcreditAddnewButton);
        }

        [Then(@"select directorcredits addnew button")]
        public void ThenSelectDirectorcreditsAddnewButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.DirectorCreditAddnewButton);
        }

        [Then(@"select productioncredits addnew button")]
        public void ThenSelectProductioncreditsAddnewButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.ProductionCreditAddnewButton);
        }



        [Then(@"select videorgrapher addnew button")]
        public void ThenSelectVideorgrapherAddnewButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.VideoGrapherCreditAddnewButton);
        }

        [Then(@"remove newly added maincredits name value")]
        public void ThenRemoveNewlyAddedMaincreditsNameValue()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.RemoveMainCredit2);
        }

        [Then(@"remove newly addedFeatured credits name value")]
        public void ThenRemoveNewlyAddedFeaturedCreditsNameValue()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.RemoveFeaturedcredit2);
        }

        [Then(@"remove newly addeddirectorcredits name value")]
        public void ThenRemoveNewlyAddeddirectorcreditsNameValue()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.RemoveDirectorCredit2);
        }

        [Then(@"remove newly addedproductioncredits name value")]
        public void ThenRemoveNewlyAddedproductioncreditsNameValue()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.RemoveProductionCredit2);
        }

        [Then(@"remove newly added videographer name value")]
        public void ThenRemoveNewlyAddedVideographerNameValue()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.RemoveVideoGrapherCredit2);
        }

        [Then(@"verfiy newly created season")]
        public void ThenVerfiyNewlyCreatedSeason()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.Newseasonverify));
        }

        [Then(@"verify newly created season delete button")]
        public void ThenVerifyNewlyCreatedSeasonDeleteButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.NewseasonDeleteButton));
        }

        [Then(@"select newly created season edit button")]
        public void ThenSelectNewlyCreatedSeasonEditButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.NewseasoneditButton);
        }

        [Then(@"enter basic tag ""(.*)"" value")]
        public void ThenEnterBasicTagValue(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValueNextTab(driver, CneBrandEditorialPage.basicTag, Value);
        }

        [Then(@"select update season button")]
        public void ThenSelectUpdateSeasonButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.NewSeasonupdateseasonButton);
        }
        
        [Then(@"verify error msg in season page")]
        public void ThenVerifyErrorMsgInSeasonPage()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.InvalidInputSeasonTitleErrorMsg));
        }

        [When(@"select Playlists in left side window of homepage")]
        public void WhenSelectPlaylistsInLeftSideWindowOfHomepage()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.Playlists);
        }

        [Then(@"select the addnew buttton")]
        public void ThenSelectTheAddnewButtton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.playlistsAddNewButton);
        }

        [Then(@"enter '(.*)' Title in Tttle for New Playlists box")]
        public void ThenEnterTitleInTttleForNewPlaylistsBox(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.DynamicPutTextValue(driver, CneBrandEditorialPage.NewplaylistsTitle);
            //CommonPage.PutTextValueNextTab(driver, CneBrandEditorialPage.NewplaylistsTitle, Value);
        }

        [Then(@"select OK button")]
        public void ThenSelectOKButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.NewplaylistsOkButton);
        }

        [Then(@"verify newly added playlist")]
        public void ThenVerifyNewlyAddedPlaylist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.NewlyCreatedPlaylist));
        }

        [Then(@"verify playlistsActiveSubcarousel Button")]
        public void ThenVerifyPlaylistsActiveSubcarouselButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.playlistsActiveSubcarouselButton));
        }


        [Then(@"select the \[not selected] dropdpwn list")]
        public void ThenSelectTheNotSelectedDropdpwnList()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.NotSelected);
        }

        [Then(@"select Active in the list")]
        public void ThenSelectActiveInTheList()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.playlistsActive);
        }

        [Then(@"verify the result of Active  playlist")]
        public void ThenVerifyTheResultOfActivePlaylist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.ActivePlaylistAfterEnable));
        }

        [Then(@"select non active in the list")]
        public void ThenSelectNonActiveInTheList()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.playlistsNotActive);
        }

        [Then(@"verify the result of non active playlist")]
        public void ThenVerifyTheResultOfNonActivePlaylist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            //Assert.IsFalse(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.ActivePlaylistAfterEnable));
        }

        [Then(@"select programing in the list")]
        public void ThenSelectProgramingInTheList()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.playlistsPrograming);
        }

        [Then(@"verify the result of programing playlist")]
        public void ThenVerifyTheResultOfProgramingPlaylist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            //Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.NewlyCreatedPlaylist)); //need to verify again isfalse condition
        }

        [Then(@"select view playlist")]
        public void ThenSelectViewPlaylist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.ViewplaylistsButton);
        }

        [Then(@"verify generateslug button exsist")]
        public void ThenVerifyGenerateslugButtonExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.GeneratSlug));
        }

        [Then(@"verify SqaurePreview button exsist")]
        public void ThenVerifySqaurePreviewButtonExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.playlistSquarPreviewButton));
        }

        [Then(@"verify CoustmizedEmbed button exsist")]
        public void ThenVerifyCoustmizedEmbedButtonExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.playlistsCustomizeEmbed));
        }

        [Then(@"verify BranddropDown button exsist")]
        public void ThenVerifyBranddropDownButtonExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.playlistsselectBrandButton));
        }

        [Then(@"verify Sponsored check box  exsist")]
        public void ThenVerifySponsoredCheckBoxExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.SponsoredCheckBox));
        }

        [Then(@"verify AddVideo button exsist")]
        public void ThenVerifyAddVideoButtonExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.playlistsAddVideoDropDown));
        }

        [Then(@"verify the delete button exsist")]
        public void ThenVerifyTheDeleteButtonExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.EditplaylistsDeleteButton));
        }

        [Then(@"select ActiveplaylistsCheckBox Button")]
        public void ThenSelectActiveplaylistsCheckBoxButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.ActiveplaylistsCheckBoxButton);
        }


        [Then(@"select image to upload")]
        public void ThenSelectImageToUpload()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
           // CommonPage.ClickableElement(driver, CneBrandEditorialPage.playlistsposterFrame);
        }

        [Then(@"select the save button exsist")]
        public void ThenSelectTheSaveButtonExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickandEnter(driver, CneBrandEditorialPage.EditplaylistsSaveButton);
        }

        [Then(@"Select delete button")]
        public void ThenSelectDeleteButton()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickandEnter(driver, CneBrandEditorialPage.EditplaylistsDeleteButton);
        }

        [Then(@"Verify Added playlist not exsist")]
        public void ThenVerifyAddedPlaylistNotExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
              Assert.IsFalse(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.Removedaddedplaylist));  //need to verify again isfalse condition
        }


        [When(@"select Email lists in left side window of homepage")]
        public void WhenSelectEmailListsInLeftSideWindowOfHomepage()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.EmailLists);
        }

        [Then(@"enter ""(.*)"" in CaptionAlerts email box editable")]
        public void ThenEnterInCaptionAlertsEmailBoxEditable(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValueNextTab(driver, CneBrandEditorialPage.CaptionAlertEmailAddress, Value);
        }

        [Then(@"select Add button exsist")]
        public void ThenSelectAddButtonExsist()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.CaptionAlertEmailAddButton);
        }

        [Then(@"select ""(.*)"" delete button")]
        public void ThenSelectDeleteButton(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            if (Value.Contains("eniyan@gmail.com"))
            {
                CommonPage.ClickableElement(driver, CneBrandEditorialPage.CaptionAlertEmailDeleteButton);
            }
            else
            {
                Thread.Sleep(3000);
            }
        }

        [Then(@"verify ""(.*)"" error msg in emaillist")]
        public void ThenVerifyErrorMsgInEmaillist(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            if (Value.Contains("eniyan@gmail.com"))
            {
                Thread.Sleep(3000);
            }
            else
            {
                Assert.IsTrue(CommonPage.VerifyElementDisplayed(driver, CneBrandEditorialPage.EmailErrormsg));
            }
        }


        [Then(@"enter ""(.*)"" in PublishedToday email box editable")]
        public void ThenEnterInPublishedTodayEmailBoxEditable(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValueNextTab(driver, CneBrandEditorialPage.publishedTodayEmailAddress, Value);
        }

        [Then(@"select Add button exsist in PublishedToday")]
        public void ThenSelectAddButtonExsistInPublishedToday()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.publishedTodayEmailAddButton);
        }

        [Then(@"select ""(.*)"" PublishedToday delete button")]
        public void ThenSelectPublishedTodayDeleteButton(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            if (Value.Contains("eniyan@gmail.com"))
            {
                CommonPage.ClickableElement(driver, CneBrandEditorialPage.publishedTodayEmailDeleteButton);
            }
            else
            {
                Thread.Sleep(3000);
            }
        }

        [Then(@"enter ""(.*)"" in VideoAlerts email box editable")]
        public void ThenEnterInVideoAlertsEmailBoxEditable(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.PutTextValueNextTab(driver, CneBrandEditorialPage.VideoAlertEmailAddress, Value);
        }

        [Then(@"select Add button exsist in VideoAlerts")]
        public void ThenSelectAddButtonExsistInVideoAlerts()
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneBrandEditorialPage.VideoAlertEmailAddButton);
        }


        [Then(@"select ""(.*)"" VideoAlerts delete button")]
        public void ThenSelectVideoAlertsDeleteButton(string Value)
        {
            CneBrandEditorialPage = new CneBrandEditorialPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            if (Value.Contains("eniyan@gmail.com"))
            {
                CommonPage.ClickableElement(driver, CneBrandEditorialPage.VideoAlertEmaildeleteButton);
            }
            else
            {
                Thread.Sleep(3000);
            }
        }


    }




}

