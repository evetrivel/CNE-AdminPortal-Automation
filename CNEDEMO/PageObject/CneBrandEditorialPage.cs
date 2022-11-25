using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CNEDEMO.PageObject
{
    public class CneBrandEditorialPage
    {
        IWebDriver driver;
        public CommonPage commonPage;

        public CneBrandEditorialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string SerieAndSeasons = "//div[@class = 'cn-body container-fluid']//a[text()='Series & Seasons']";
        public string Playlists = "//div[@class = 'cn-body container-fluid']//a[text()='Playlists']";
        public string WatchPageLinks = "//div[@class = 'cn-body container-fluid']//a[text()='Watch Page Links']";
        public string EmailLists = "//div[@class = 'cn-body container-fluid']//a[text()='Email Lists']";
        public string AddNewSeries = "//*[text()='Add New Series']";
        public string SaveOrder = "//*[text()='Save Order']";
        public string TitleNewSeries = "//div[@class = 'span10 cn-page-content']//input[@id='series_title']";
        public string CreateSeriesButton = "//div[@class = 'span10 cn-page-content']//input[@name='commit']";
        public string AddSeason = "//div[@class = 'span10 cn-page-content']//a[text()='Add Season']";
        public string SeasonEditButton = "//div[@class = 'span10 cn-page-content']//a[text()=' Edit']";
        public string SeasonDeleteButton = "//div[@class = 'span10 cn-page-content']//a[text()=' Delete']";
        public string Season1 = "//div[@class = 'span10 cn-page-content']//*[text()='Season 1']";
        public string UpdateSeriesButton = "//div[@class = 'span10 cn-page-content']//input[@name='commit']";
        public string NewSeriesEditButton = "(//div[@class = 'span10 cn-page-content']//a[text()='Edit Series'])[1]";
        public string BasicSeasonTitle = "//div[@class = 'span10 cn-page-content']//input[@id='season_title']";
        // public string SelectImageToUpload1 = "(//div[@class = 'span10 cn-page-content']//span[text()='Select Image to Upload'])[1]";
        //public string SelectImageToUpload2 = "(//div[@class = 'span10 cn-page-content']//span[text()='Select Image to Upload'])[2]";
        public string SelectImageToUpload1 = "(//div[@class = 'span10 cn-page-content']//span[@class='button btn'])[1]";
        public string SelectImageToUpload2 = "(//div[@class = 'span10 cn-page-content']//span[@class='button btn'])[2]";
        
        public string SeriesCategories = "(//div[@class = 'span10 cn-page-content']//input[@type='text'])[2]";
        public string InvalidInputErrorMsg = "//div[@class='cn-body container-fluid']//div[@class='alert alert-error']/a";
        public string InvalidInputSeasonTitleErrorMsg = "(//div[@class='span10 cn-page-content']//span)[1]";
        
        public string HostButton = "//div[@class = 'span10 cn-page-content']//a[text()='Host']";
        public string CreditsButton = "//div[@class = 'span10 cn-page-content']//a[text()='Credits']";
        public string EpisodeOrderingButton = "//div[@class = 'span10 cn-page-content']//a[text()='Episodes Ordering']";
        public string BasicButton = "//div[@class = 'span10 cn-page-content']//a[text()='Basic']";

        public string Newseasonverify = "//div[@class = 'span10 cn-page-content']//*[text()='Season 2']";

        public string BasicCreateSeasonButton = "//div[@class = 'span10 cn-page-content']//input[@name='commit']";
        public string HostCreateSeasonButton = "//div[@class = 'span10 cn-page-content']//input[@name ='commit']";
        public string CreditCreateSeasonButton = "//div[@class = 'span10 cn-page-content']//input[@name ='commit']";
        public string EpiOrderingCreateSeasonButton = "//div[@class = 'span10 cn-page-content']//input[@name ='commit']";

        public string MainCreditName = "//div[@class = 'span10 cn-page-content']//input[@name='credits[main][][name]']";
        public string FeaturedcreditName = "//div[@class = 'span10 cn-page-content']//input[@name='credits[featured][][name]']";
        public string DirectorCreditName = "//div[@class = 'span10 cn-page-content']//input[@name='credits[director][][name]']";
        public string ProductionCreditName = "//div[@class = 'span10 cn-page-content']//input[@name='credits[production][][name]']";
        public string VideoGrapherCreditName = "//div[@class = 'span10 cn-page-content']//input[@name='credits[videographer][][name]']";
        public string LegalCredits = "//div[@class = 'span10 cn-page-content']//*[@id='season_legal_credits']";

        public string HostTitle = "(//div[@class = 'span10 cn-page-content']//input[@class='select2-input'])[2]";
        public string HostIntro = "//div[@class = 'span10 cn-page-content']//select[@id='season_host_intro']//*[text()='Starring']";
        public string HostImageselectuploadbutton = "(//div[@class = 'span10 cn-page-content']//span[text()='Select Image to Upload'])[3]";

        public string MainCreditAddnewButton = "(//div[@class = 'span10 cn-page-content']//a[text()='Add new '])[1]";
        public string FeaturedcreditAddnewButton = "(//div[@class = 'span10 cn-page-content']//a[text()='Add new '])[2]";
        public string DirectorCreditAddnewButton = "(//div[@class = 'span10 cn-page-content']//a[text()='Add new '])[3]";
        public string ProductionCreditAddnewButton = "(//div[@class = 'span10 cn-page-content']//a[text()='Add new '])[4]";
        public string VideoGrapherCreditAddnewButton = "(//div[@class = 'span10 cn-page-content']//a[text()='Add new '])[5]";

        public string MainCreditName2 = "(//div[@class = 'span10 cn-page-content']//input[@name='credits[main][][name]'])[2]";
        public string FeaturedcreditName2 = "(//div[@class = 'span10 cn-page-content']//input[@name='credits[featured][][name]'])[2]";
        public string DirectorCreditName2 = "(//div[@class = 'span10 cn-page-content']//input[@name='credits[director][][name]'])[2]";
        public string ProductionCreditName2 = "(//div[@class = 'span10 cn-page-content']//input[@name='credits[production][][name]'])[2]";
        public string VideoGrapherCreditName2 = "(//div[@class = 'span10 cn-page-content']//input[@name='credits[videographer][][name]'])[2]";
        


        public string MainCreditCelebrityTypeDropdown = "//div[@class = 'span10 cn-page-content']//select[@name='credits[main][][celebrity_type]']//*[text()='Actor']";
        public string FeaturedcreditCelebrityTypeDropdown = "//div[@class = 'span10 cn-page-content']//select[@name='credits[featured][][celebrity_type]']//*[text()='Actor']";
        public string DirectorCreditCelebrityTypeDropdown = "//div[@class = 'span10 cn-page-content']//select[@name='credits[director][][celebrity_type]']//*[text()='Actor']";
        public string ProductionCreditProductionroleDropdown = "//div[@class = 'span10 cn-page-content']//select[@name='credits[production][][celebrity_type]']//*[text()='Animator']";

        public string RemoveMainCredit2 = "(//div[@class = 'span10 cn-page-content']//i[@class='icon-remove item-remove'])[2]";
        public string RemoveFeaturedcredit2 = "(//div[@class = 'span10 cn-page-content']//i[@class='icon-remove item-remove'])[3]";
        public string RemoveDirectorCredit2 = "(//div[@class = 'span10 cn-page-content']//i[@class='icon-remove item-remove'])[4]";
        public string RemoveProductionCredit2 = "(//div[@class = 'span10 cn-page-content']//i[@class='icon-remove item-remove'])[5]";
        public string RemoveVideoGrapherCredit2 = "(//div[@class = 'span10 cn-page-content']//i[@class='icon-remove item-remove'])[6]";

        public string NewseasonDeleteButton = "(//div[@class = 'span10 cn-page-content']//a[text()=' Delete'])[2]";
        public string NewseasoneditButton = "(//div[@class = 'span10 cn-page-content']//a[text()=' Edit'])[2]";

        public string basicTag = "(//div[@class = 'span10 cn-page-content']//input[@class='select2-input'])[1]";
        public string NewSeasonupdateseasonButton = "//div[@class = 'span10 cn-page-content']//input[@name='commit']";

        public string playlistsAddNewButton  = "//div[@class='span10 cn-page-content']//button[text()='Add New']";
        public string playlistsActive = "//div[@class='span10 cn-page-content']//select[@id='filter_option']//*[text()='Active']";
        public string NotSelected = "//div[@class='span10 cn-page-content']//select[@id='filter_option']//*[text()='[Not Selected]']";
        public string playlistsNotActive = "//div[@class='span10 cn-page-content']//select[@id='filter_option']//*[text()='Not Active']";
        public string playlistsPrograming = "//div[@class='span10 cn-page-content']//select[@id='filter_option']//*[text()='Programming']";
        public string NewplaylistsTitle = "//input[@id='js-new-video-group-title']";
        public string NewplaylistsOkButton = "//div[@class='ui-dialog-buttonpane ui-widget-content ui-helper-clearfix']//button[text()='ok']";
        public string NewlyCreatedPlaylist = "(//div[@class='span10 cn-page-content']//div[contains(@id,'video_group_')])[1]";
        public string ViewplaylistsButton = "(//div[@class='span10 cn-page-content']//a[text()='View Playlist'])[1]";
        public string playlistsActiveSubcarouselButton = "(//div[@class='span10 cn-page-content']//a[text()='Set As Active Subcarousel'])[1]";
        public string EditplaylistsSaveButton = "//div[@class='span10 cn-page-content']//button[text()='Save']";
        public string EditplaylistsDeleteButton = "//div[@class='span10 cn-page-content']//button[text()='Delete']";
        public string ActiveplaylistsCheckBoxButton = "//div[@class='span10 cn-page-content']//input[@id='video_group_active_playlist']";
        public string SponsoredCheckBox = "//div[@class='span10 cn-page-content']//input[@id='video_group_sponsored']";
        public string GeneratSlug = "(//div[@class='js-video-group-form span7']//a)[1]";
        public string playlistsposterFrame = "//div[@class='span10 cn-page-content']//span[text()='Select Image to Upload']";
        public string playlistSquarPreviewButton = "//div[@class='span10 cn-page-content']//button[text()='Square Preview']";
        public string playlistsCustomizeEmbed = "//div[@class='span10 cn-page-content']//a[text()='Customize Embed']";
        public string playlistsselectBrandButton = "//div[@class='span10 cn-page-content']//select[@class='video-group-edit-pane__brand-select js-video-group-edit-pane__brand-select']//*[text()='All Brands']";
        public string playlistsAddVideoDropDown = "//div[@class='span10 cn-page-content']//a/span[text()='Add a Video']";
        public string Removedaddedplaylist = "//div[@class='span10 cn-page-content']//*[text()='testxyz']";
        public string ActivePlaylistAfterEnable = "(//div[@class='span10 cn-page-content']//span[text()='Active Playlist'])[1]";


        public string VideoAlertEmailAddButton = "(//div[@class='span10 cn-page-content']//*[text()='Add'])[1]";
        public string VideoAlertEmailAddress = "(//div[@class='span10 cn-page-content']//input[@placeholder='Add Email'])[1]";
        public string publishedTodayEmailAddButton = "(//div[@class='span10 cn-page-content']//*[text()='Add'])[2]";
        public string publishedTodayEmailAddress = "(//div[@class='span10 cn-page-content']//input[@placeholder='Add Email'])[2]";
        public string CaptionAlertEmailAddButton = "(//div[@class='span10 cn-page-content']//*[text()='Add'])[3]";
        public string CaptionAlertEmailAddress = "(//div[@class='span10 cn-page-content']//input[@placeholder='Add Email'])[3]";
        public string VideoAlertEmaildeleteButton =  "(//div[@class='span10 cn-page-content']//span[text()='Delete'])[last()]";
        public string publishedTodayEmailDeleteButton = "(//div[@class='span10 cn-page-content']//span[text()='Delete'])[last()]";
        public string CaptionAlertEmailDeleteButton = "(//div[@class='span10 cn-page-content']//span[text()='Delete'])[last()]";
        public string EmailErrormsg = "(//div[@class='span10 cn-page-content']//*[text()='Please enter a valid email address.'])";

    }
}

