using CNEDEMO.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CNEDEMO.PageObject
{
    public class CommonPage
    {
        public IWebDriver driver { get; set; }

        


        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public CommonPage WaitWhileLoadingImagePresent()
        {
            Thread.Sleep(2000);
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            w.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='loading -overlay']")));
            return this;
        }

        public bool ValidateBrowserTitle(string browserTitle)
        {
            return driver.Title.Contains(browserTitle);
        }

        public IWebElement GetText(string text)
        {
            return driver.FindElement(By.XPath($"//*[text()= '{text}']"));
        }
        public IWebElement GetTextIndexed(string text, int index)
        {

            return driver.FindElements(By.XPath($"//*[text()= '{text}']")).ElementAt(index);


        }
        public bool ValidateBrowserExactTitle(string browserTitle)
        {
            return driver.Title.Equals(browserTitle);
        }

        public static void WaitForElement(IWebDriver driver, string xpath, int time = 45)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
        }
        public static void WaitForElementInvisible(IWebDriver driver, string xpath, int time = 45)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(xpath)));
        }

        public static void ClickableElement(IWebDriver driver, string xpath)
        {
            Thread.Sleep(5000);
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).Click();
        }


        public static bool VerifyElementDisplayed(IWebDriver driver, string xpath)
        {
            Thread.Sleep(2000);
            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }

        public static bool IsElementPresent(IWebDriver driver, string xpath)
        {
            try
            {
                driver.FindElement(By.XPath(xpath));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool VerifyMentionedElementDisplayed(IWebDriver driver, string xpath, string value)
        {
            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }

        public static bool VerifyListedElementDisplayed(IWebDriver driver, string Value)
        {
            string xpath = "//div[@class = 'right d-none d-sm-block']//div[@class='row']//div[text()='" + Value + "']";
            WaitForElement(driver, xpath);
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }

        public static bool VerifyListedCountryDisplayed(IWebDriver driver, string Value)
        {
            string xpath = "//div[@class = 'cne-brand-dropdown__container']//li[text()='" + Value + "']";
            WaitForElement(driver, xpath);
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }


        public static string GetTextValue(IWebDriver driver, string xpath)
        {
            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Text;
        }

        public static string[] GetTextValueFromElements(IWebDriver driver, string xpath)
        {
            WaitForElement(driver, xpath);
            var arr = new List<string>();
            foreach (IWebElement ele in driver.FindElements(By.XPath(xpath)))
            {
                Console.WriteLine(ele.Text);
                arr.Add(ele.Text);
            }
            Console.WriteLine(arr.ToArray());
            return arr.ToArray();
        }

        public static void PutTextValue(IWebDriver driver, string xpath, string value)
        {
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public static void PutTextValueForTags(IWebDriver driver, string xpath, string value)
        {
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).SendKeys(value + Keys.Enter);
        }

        public static void PutTextValueNextTab(IWebDriver driver, string xpath, string value)
        {
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).SendKeys(value + Keys.Tab);
        }
        public static void ClickandEnter(IWebDriver driver, string xpath)
        {
            WaitForElement(driver, xpath);
            //Action keyAction = new Action(driver);
            driver.FindElement(By.XPath(xpath)).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            
            driver.SwitchTo().Alert().Accept();

        }

        public static void PutTextValueandSelectDropDownvalue(IWebDriver driver, string xpath, string value)
        {
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).SendKeys(value + Keys.Down + Keys.Enter);
        }

        public static void dragandDropElement(IWebDriver driver, string xpath , string FilePath)
        {
            Thread.Sleep(5000);
            WaitForElement(driver, xpath);
            
            IWebElement drag = driver.FindElement(By.XPath(xpath));
            drag.SendKeys("FilePath");
            Thread.Sleep(2000);
            //driver.SwitchTo.defaultContent();

            

            /*AutoITX autoIt = new AutoITX();
            autoIt.WinActivate("Open"); // Window name to select a file 
            autoIt.Send(@FilePath); // file path 
            autoIt.Send("{Enter}");*/
            /* StringSelection s = new StringSelection(FilePath);
             Toolkit.getDefaultToolkit().getSystemClipboard().setContents(s, null);
             Robot robot = new Robot();
             robot.keyPress(java.awt.event.KeyEvent.VK_ENTER);
         robot.keyRelease(java.awt.event.KeyEvent.VK_ENTER);
         robot.keyPress(java.awt.event.KeyEvent.VK_CONTROL);
         robot.keyPress(java.awt.event.KeyEvent.VK_V);
         robot.keyRelease(java.awt.event.KeyEvent.VK_CONTROL);
         Thread.sleep(3000);
             robot.keyPress(java.awt.event.KeyEvent.VK_ENTER);*/

        }
       


            public static void SelectFromDropDown(IWebDriver driver, string xpath, string value, string selectBy)
        {
            WaitForElement(driver, xpath);
            IWebElement DropDownElement = driver.FindElement(By.XPath(xpath));
            SelectElement SelectValue = new SelectElement(DropDownElement);

            switch (selectBy)
            {
                case "SelectByText":
                    SelectValue.SelectByText(value);
                    break;
                case "SelectByValue":
                    SelectValue.SelectByValue(value);

                    break;
            }

        }

        public static void EnterValuesInTextBox(IWebDriver driver, string xpath, string value)
        {
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public static void NavigateToPage(IWebDriver driver, string xpath)
        {

            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).Click();
        }
        /// <summary>
        /// For selecting values from list 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="Value"></param>
        public static void SelectListValue(IWebDriver driver, string Value)
        {
            string xpath = "//span[text()='" + Value + "']";
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public static void BrandSelectListValue(IWebDriver driver, string Value)
        {
            string xpath = "//div[@class = 'cne-brand-dropdown__container']//li[text()='" + Value + "']";
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public static void ContentSelectListValue(IWebDriver driver, string Value)
        {
            string xpath = "//div[@class = 'span10 cn-page-content']//select[@id='content_library_content_type']//*[text()='" + Value + "']";
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public static void BrandListValue(IWebDriver driver, string Value)
        {
            string xpath = "(//*[text()='" + Value + "'])[4]";
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public static void VideoEditSelectListValue(IWebDriver driver, string Value)
        {
            string xpath = "(//div[@class = 'span10 cn-page-content']//div[@class = 'cne-buttons']//a[text()='" + Value + "'])[1]";
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public static void CountrySelectListValue(IWebDriver driver, string Value)
        {
            string xpath = "//div[@class = 'cne-brand-dropdown__container']//li[text()='" + Value + "']";
            WaitForElement(driver, xpath);
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public static bool checkdropdownValue(IWebDriver driver, string Value)
        {
            string xpath = "//*[text()='" + Value + "']";
            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }

        public static bool checkradioValue(IWebDriver driver, string Value)
        {
            string xpath = "//*[text()='" + Value + "']";
            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }

        public static bool checkfieldValue(IWebDriver driver, string Value)
        {
            string xpath = "//*[text()='" + Value + "']";
            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }

        public static bool PopfieldValue(IWebDriver driver, string text)
        {

            string xpath = "//*[contains(text(),'" + text + "')]";
            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }

        public static bool ModulefieldValue(IWebDriver driver, string text)
        {

            string xpath = "//div[@class='mt-1 mb-1']//*[contains(text(),'" + text + "')]";
            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }
        public static bool ContactfieldValue(IWebDriver driver, string text)
        {
            string xpath = "//div[@class = 'right d-none d-sm-block']//*[contains(text(),'" + text + "')]";

            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }

        public static bool ViewsummaryPopfieldValue(IWebDriver driver, string text)
        {
            string xpath = "//div[@class = 'right d-none d-sm-block']//*[text()='" + text + "']";
            WaitForElement(driver, xpath);
            return driver.FindElement(By.XPath(xpath)).Displayed;
        }

        public static void checkradioValueclick(IWebDriver driver, string Value)
        {

            string xpath = "//*[contains(text(), '" + Value + "')]//preceding-sibling::input";
            WaitForElement(driver, xpath);
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public static void checkdropdownValueclick(IWebDriver driver, string xpath, string value, string selectBy)
        {

            WaitForElement(driver, xpath);
            IWebElement DropDownElement = driver.FindElement(By.XPath(xpath));
            SelectElement SelectValue = new SelectElement(DropDownElement);

            switch (selectBy)
            {
                case "SelectByText":
                    SelectValue.SelectByText(value);
                    break;
                case "SelectByValue":
                    SelectValue.SelectByValue(value);

                    break;
            }
        }

        public static void scrollDown(IWebDriver driver, string element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,-350)", "");
        }

        public static void scrollUp(IWebDriver driver, string element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,-250)" , "");

           // js.ExecuteScript("window.scrollBy(0,-350)", "");
        }

        public static void clickableJavaElement(IWebDriver driver, string xpath)
        {

            WaitForElement(driver, xpath);
            IWebElement element  = driver.FindElement(By.XPath(xpath));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

           // js.ExecuteScript("document.getElementsByName('element').click();");    
                       js.ExecuteScript("arguments[0].click();", element);
        }

        public static void switchLastWnd(IWebDriver driver)
        {
            Thread.Sleep(5000);
            System.Collections.ObjectModel.ReadOnlyCollection<string> handles = driver.WindowHandles;
            driver.SwitchTo().Window(handles[handles.Count - 1]);
            WaitHelper.WaitUntilPageLoads(driver);
        }

        private static Random random = new Random();
        private static string RandomKey(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void DynamicPutTextValue(IWebDriver driver, string xpath)
        {

            Random random = new Random();
            int randomint = random.Next(1000);
            
            WaitForElement(driver, xpath);
           IWebElement element = driver.FindElement(By.XPath(xpath));
            element.SendKeys("Reg_Test/" + randomint + "/2022");
        }

    }
}
