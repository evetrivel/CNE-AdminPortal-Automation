using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CNEDEMO.PageObject
{
    public class CnePages
    {
        IWebDriver driver;
        public CommonPage commonPage;

        public CnePages(IWebDriver driver)
        {
            this.driver = driver;
        }


        public string CneLogo = "//div[@class =\"row-fluid\"]//img[@class=\"cn-logo pull-left\"]";
        public string UserNameTextBox = "//div[@class = \"auth-content\"]//input[contains (@id, \"username\")]";
        public string NextButton = "//div[@class = \"o-form-button-bar\"]//input[contains (@value, \"Next\")]";
        public string PassowrdTextBox = "//div[@class = \"auth-content\"]//input[contains (@id, \"okta-signin-password\")]";
        public string SigninButton = "//div[@class = \"o-form-button-bar\"]//input[contains (@value, \"Sign In\")]";
        public string SendPush = "//div[@class = \"o-form-button-bar\"]//input[contains (@value, \"Send Push\")]";
        public string SelectBrandButton = "//span[text()=\"Select Brand ▾\"]";
        public string BrandLogo = "//div[@class =\"row-fluid\"]//img[@class=\"pull-right cn-brand-logo\"]";
        public string NewVideoButton = "//div[@class = 'span10 cn-page-content']//a[@id='cn-new-video']";
        public string RowPerPage = "//div[@class = 'span10 cn-page-content']//p[@id='mui-19870']";
        public string NewVideoPage = "//div[@class = 'span10 cn-page-content']//h3[text()='New  video ']";
        public string CancelButton = "//div[@class = 'span10 cn-page-content']//a[text()='Cancel']";
        public string SaveButton = "//div[@class = 'span10 cn-page-content']//input[@name='commit']";
        public string OAndODropDown = "//div[@class = 'span10 cn-page-content']//div[@id='oo-header' and text()='O&O']";
        public string OOVideoTitle = "//div[@class = 'span10 cn-page-content']//input[@id='video_title']";
        public string VideoCatgory = "//div[@class = 'span10 cn-page-content']//input[@id='video_categories']";
        public string VideoDiscription = "//div[@class = 'span10 cn-page-content']//textarea[@id='video_description']";
        public string VidoeTag = "//div[@class = 'span10 cn-page-content']//input[@id='video_tags']";
        public string SlugButton = "//div[@class = 'span10 cn-page-content']//button[@id='video-generate-slug']";
        public string VerifyNewlyAddedVideo = "//div[@class='span10 cn-page-content']//div[@class='cn-video-title']";
        public string ScheduleTab = "//div[@class = 'video-metadata-edit-form']//div[@id='scheduling-header']";
        public string YoutubecheckBox = "//div[@class = 'scheduling-group-endpoints-wrapper']//div[text()='YouTube']";
        public string FacebookcheckBox = "//div[@class = 'scheduling-group-endpoints-wrapper']//div[text()='Facebook']";
        public string YoutubeTab = "//div[@id= 'youtube-header']";
        public string YoutubeChannel = "//div[@class = 'MuiCollapse-container MuiCollapse-entered']//select[@id='video_youtube_metadatum_attributes_youtube_channel_id']//*[text()='CondéNast TestChannel']";
       // public string YoutubeChannel = "//div[@class = 'MuiCollapse-container MuiCollapse-entered']//select[@id='video_youtube_metadatum_attributes_youtube_channel_id']";
        public string YoutubeTags = "//div[@class = 'form__input form__input--tags']//input[@id= 'video_youtube_metadatum_attributes_tags']";
        public string YoutubeDescription = "//div[@class='MuiCollapse-container MuiCollapse-entered']//textarea[@id='video_youtube_metadatum_attributes_description']";
        public string YoutubeCategory = "//div[@class = 'form__input-text']//select[@id= 'video_youtube_metadatum_attributes_category']";
        public string FacebookTab = "//div[@id= 'facebook-header']";
        public string FacebookTags = "//div[@class = 'form__input form__input--tags']//input[@id = 'video_facebook_metadatum_attributes_tags']";
        public string OOErrorMsg = "//div[@class = 'video-metadata-edit-form']//b";
        public string FacebookDescription = "//div[@class='MuiCollapse-container MuiCollapse-entered']//textarea[@id='video_facebook_metadatum_attributes_description']";
        public string EditButton = "(//div[@class = 'span10 cn-page-content']//div[@class = 'cne-buttons']//a)[1]";
        public string EditButtonIcon = "(//div[@class = 'span10 cn-page-content']//div[@class = 'cne-title']//i)[1]";
        public string VideoMedia = "//div[@class = 'span10 cn-page-content']//a[text()='Video Media']";
        public string UploadOOPosterFrameButton = "(//div[@class = 'span10 cn-page-content']//span[text()='Upload Poster Frame'])[1]";
        public string UploadyoutubePosterFrameButton = "(//div[@class = 'span10 cn-page-content']//span[text()='Upload Poster Frame'])[2]";
        public string UploadOOTPosterFrameButton = "(//div[@class = 'span10 cn-page-content']//span[text()='Upload Poster Frame'])[3]";
        public string UploadAddSourceVideoButton = "//div[@class = 'span10 cn-page-content']//span[text()='Upload Video Source']";
        public string DownloadOOPosterFrameButton = "(//div[@class = 'span10 cn-page-content']//a[text()='Download'])[1]";
        public string DownloadyoutubePosterFrameButton = "(//div[@class = 'span10 cn-page-content']//a[text()='Download'])[2]";
        public string DragandDrop = "//div[@class = 'react-modal__body']//div[@class = 'mb-1']//descendant::*[last()]";
        public string VideodragDrop = "//div[@class = 'source-upload-container']//div[@class = 'mb-1']//descendant::*[last()]";
        public string CropimageButton = "//span[text()='Crop Image']";
        public string Editcrop = "//span[text()='Edit Crop']";
        public string Closebutton = "//span[text()='Close']";
        public string ReplaceVideo = "//span[text()='Replace Video']";
        public string Replacevideopopupbutton = "//div[@class = 'replace-video']//span[text()='Replace Video']";
        public string OOAnimatedThumbnail = "//div[@class='cn-tab-content']//video[@autoplay = '']";
        public string OOPosterframefromthumbnails = "//div[@class = 'row']/img[1]";
        public string ExternalId = "//div[@class = 'span10 cn-page-content']//a[text()='External IDs']";
        public string YoutubeEid = "//div[@class = 'cn-body container-fluid']//input[@name = 'ids[youtube]' ]";
        public string FacebookEid = "//div[@class = 'cn-body container-fluid']//input[@name ='ids[facebook]']";
        public string SaveEid = "//div[@class = 'span10 cn-page-content']//button[text() ='Save']";
        public string MidrollCuePoints = "//div[@class = 'span10 cn-page-content']//a[text()='Mid-roll Cue Points']";
        public string MidrollCuePointsforwardbutton = "//div[@id = 'shift-buttons']//a[@class = 'shift btn pull-right']";
        public string MidrollCuePointsbackwardbutton = "//div[@id = 'shift-buttons']//a[@class = 'shift btn pull-left']";
        public string MidrollCuePointSavebutton = "//input[@name  = 'commit']";
        public string MidrollCuePointdeletebutton = "//div[@id='cue-point-table']//a[text()='Delete']";
        public string MidrollCuePointsrecord = "//div[@id = 'cue-point-table']//tr[2]";
        public string Geofencing = "//div[@class = 'span10 cn-page-content']//a[text()='O&O Geofencing']";
        public string GeofencingSave = "//button[text()='Save']";
        public string Geofencingavalablein = "//div[@class = 'control-group select optional video_geo_available']//input[@type='text']";
        public string Geofencingblockin = "//div[@class = 'control-group select optional video_geo_blocked']//input[@type='text']";
        public string VideoHyperLink = "(//div[@class = 'span10 cn-page-content']//div[@class = 'cne-title']//a)[1]";
        public string VideoiconrBiefcase = "(//div[@class = 'span5']//div[@class = 'cne-video-preview']//i)[3]";
        public string VideoiconrShare = "(//div[@class = 'span5']//div[@class = 'cne-video-preview']//i)[2]";
        public string VideoLogIconEdit = "(//div[@class = 'span5']//div[@class = 'cne-video-preview']//i)[1]";
        public string GenerateButton = "//div[@class = 'span5']//div[@class = 'cne-video-preview']//button[text()='generate']";
        public string GeneratelinkDeleteButton = "//div[@class = 'span5']//div[@class = 'cne-video-preview']//button[text()='delete']";
        public string URLLink = "(//div[@class = 'span5']//div[@class = 'cne-video-preview']//a)[4]";
        public string PreviewLink = "(//div[@class = 'span5']//div[@class = 'cne-video-preview']//a)[5]";
        public string FbLink = "(//div[@class = 'span5']//div[@class = 'cne-video-preview']//a)[6]";
        public string youTubeLink = "(//div[@class = 'span5']//div[@class = 'cne-video-preview']//a)[7]";
        public string source = "//*[text()='source']";
        public string high = "//*[text()='high']";
        public string low = "//*[text()='low']";
        public string hls = "//*[text()='hls']";
        public string mobile = "//*[text()='mobile']";
        public string DOWNLOADPOSTERFILES = "//*[text()='O&O Poster Frame']";
        public string VideoLogDetials = "(//span[text()='finished'])[1]";
        public string ErrorVideoLogDetials = "(//*[text()='error'])[last()]";
        public string VideoLogCloseButton = "//button[@class = 'ui-dialog-titlebar-close']";
        public string AllBrandVideo = "//div[@class = 'cn-body container-fluid']//a[text()='All Brand Videos']";
        public string TotalVideoCount = "//div[@class = 'span10 cn-page-content']//p[contains(text() , '1-50')]";
        public string AllVideoRowperpage = "//div[@class = 'span10 cn-page-content']//div[contains (@id ,  'mui-')]";
        public string VideoperPage10 = "//li[text()='10']";
        public string VideoperPage25 = "//li[text()='25']";
        public string VideoperPage50 = "//li[text()='50']";
        public string VideoperPage100 = "//li[text()='100']";
        public string NextPage = "//div[@class = 'span10 cn-page-content']//button[@aria-label ='Next page']";
        public string PreviousPage = "//div[@class = 'span10 cn-page-content']//button[@aria-label ='Previous page']";
        public string Videocount = "//div[@class = 'span10 cn-page-content']//p[contains(text() , '1-10')]";
        public string GlobalLocalization = "//div[@class = 'cn-body container-fluid']//a[text()='Global Localization']";
        public string GlobalSelect = "//div[@class = 'copy-action-modal-footer']//span[2]";
        public string GlobalCopy = "(//div[text()='Copy'])[1]";
            public string GlobalSelectBrand = "//div[@class = 'react-modal__mask react-modal--sm new-design react-fade-appear-done react-fade-enter-done']//span[text()='​']";
        public string GlobalAnyBrand = "(//*[text()='Allure'])[4]";
        public string GlobalPopupExit = "(//*[local-name()='svg']//*[local-name()='path'])[5]";
        public string VideoSearchBox = "//div[@class = 'span10 cn-page-content']//input[@id= 'search-input']";
        public string GlobalvideoSearchBox = "//div[@class = 'span10 cn-page-content']//input[@name= 'query']";
            public string VideoSearchButton = "//div[@class = 'span10 cn-page-content']//input[@id= 'search-btn']";
            public string  VideoClearButton = "//div[@class = 'span10 cn-page-content']//input[@id= 'clear-btn']";
            public string GlobalMoreButton = "(//div[@class = 'actions-field__more-button test-more-button']//img)[1]";
            public string  GlobalViewDetials = "(//div[text()='View Details'])[1]";
            public string  videoResultVerify = "//div[@class = 'span10 cn-page-content']//tr[contains (@id ,'video_')]";
            public string  GlobalVideoDownload = "//*[text()='Download']";
        public string Globalsource = "//*[text()='Source File']";
        public string Globalhigh = "//*[text()='MP4 (High Quality)']";
        public string Globallow = "//*[text()='MP4 (Low Quality)']";
        public string Globalhls = "//*[text()='HLS']";
        public string GlobalThumbnail = "//*[text()='Thumbnail']";
        public string  GlobalYoutube = "//*[text()='YouTube']";
        public string GlobalExit = "(//div[@class = 'MuiPaper-root MuiDrawer-paper MuiDrawer-paperAnchorRight MuiPaper-elevation16']//img)[2]";
        public string GlobalVerifuResult = "(//div[@class = 'cn-body container-fluid']//tr)[2]";
        public string GlobalSearchIcon = "(//*[local-name()='svg']//*[local-name()='path'])[1]";
        public string VideoDeleteButton = "(//div[@class = 'pull-right']//a[text()='Delete'])[1]";
            public string VideoHiddenButton = "(//div[@class = 'pull-right']//a[text()='Make Hidden'])[1]";
        public string VideoEditButtonDrepdown = "(//div[@class = 'span10 cn-page-content']//a)[5]";
        public static string VideoError = "";
        public void error()
        {
            Thread.Sleep(5000);
            VideoError = driver.FindElement(By.XPath(ErrorVideoLogDetials)).Text;
        }

        public string getSavederror()
        {
            string temp = VideoError;
            
            return temp;
        }

    }
}

