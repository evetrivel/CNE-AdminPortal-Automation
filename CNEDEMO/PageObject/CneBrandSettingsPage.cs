using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CNEDEMO.PageObject
{
    public class CneBrandSettingsPage
    {
        IWebDriver driver;
        public CommonPage commonPage;

        public CneBrandSettingsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string YouTubeChannel = "//div[@class = 'cn-body container-fluid']//a[text()='YouTube Channels']";
        public string faceBookPage = "//div[@class = 'cn-body container-fluid']//a[text()='Facebook Pages']";
        public string AddNewYouTubeChannelButton = "//div[@class = 'cn-body container-fluid']//a[text()='Add New YouTube Channel']";
        public string DeleteButton = "(//div[@class = 'cn-body container-fluid']//a[text()='Delete'])[last()]";
        public string ChannelName = "//div[@class = 'cn-body container-fluid']//input[@id='youtube_channel_name']";
        public string ChannelId = "//div[@class = 'cn-body container-fluid']//input[@id='youtube_channel_channel_id']";
        public string ChannelOwnerId = "//div[@class = 'cn-body container-fluid']//input[@id='youtube_channel_content_owner_id']"; 
        public string SaveButton = "//div[@class = 'cn-body container-fluid']//button[text()='Save']";
        public string YTErrormsg = "//div[@class = 'cn-body container-fluid']//div[@class='control-group string required youtube_channel_name error']//span";
        public string AddNewFbPageButton = "//div[@class = 'cn-body container-fluid']//a[text()='Add New Facebook Page']";
        public string FbPageName = "//div[@class = 'cn-body container-fluid']//input[@id='facebook_page_name']";
        public string FbPageId = "//div[@class = 'cn-body container-fluid']//input[@id='facebook_page_page_id']";
        public string FbSaveButton = "//div[@class = 'cn-body container-fluid']//button[text()='Save']";
        public string FbErrormsg = "//div[@class = 'cn-body container-fluid']//div[@class='control-group string required facebook_page_name error']//span";

        public string IframeDeleteButton = "//button[text()='Delete']";
        public string NewlyAddedFbChannel = "//div[@class = 'span10 cn-page-content']//tr//a[text()='eni']";
        public string NewlyAddedYTchannel = "//div[@class = 'span10 cn-page-content']//tr//a[text()='eni']";
    }
}

