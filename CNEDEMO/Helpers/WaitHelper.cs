using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CNEDEMO.Helpers
{
    public class WaitHelper
    {

        public static void WaitUntilPageLoads(IWebDriver driver, int timeout = 90)
        {
            try
            {
                new WebDriverWait(driver, new TimeSpan(0, 0, timeout)).Until(
                d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            }
            catch (Exception PageLoadWaitError)
            {
                throw new TimeoutException("Timeout during page load", PageLoadWaitError);
            }
            /*new WebDriverWait(driver, new TimeSpan(0, 0, timeout)).Until(
                d => ((IJavaScriptExecutor)d).ExecuteScript("return jQuery.active==0"));

             try
             {
                 new WebDriverWait(driver, new TimeSpan(0, 0, timeout)).Until(
                     ExpectedConditions.InvisibilityOfElementWithText(By.ClassName("page-loader-header"), "Starting Configurator"));
             }
             catch (Exception e)
             {
                 Console.WriteLine(e);
             }

             try
             {
                 new WebDriverWait(driver, new TimeSpan(0, 0, timeout)).Until(
                     ExpectedConditions.InvisibilityOfElementWithText(By.ClassName("text-center"), "Loading Configurator"));
             }
             catch (Exception e)
             {
                 Console.WriteLine(e);
             }*/

            /*if (driver.SwitchTo().Window(driver.WindowHandles.Last()).Title.ToString().Equals("Where to Buy - Parker"))
            {

                new WebDriverWait(driver, new TimeSpan(0, 0, timeout)).Until(
                    ExpectedConditions.ElementIsVisible(By.Id("mCSB_1_container")));
            }
            else
            {
                try
                {
                    new WebDriverWait(driver, new TimeSpan(0, 0, timeout)).Until(
                        ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(@class,'copyrights')]")));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }*/

            /* if (driver.SwitchTo().Window(driver.WindowHandles.Last()).Title.ToString().Equals("Quote Cart"))
                 {

                     new WebDriverWait(driver, new TimeSpan(0, 0, timeout)).Until(
                         ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class,\"col - md - 8 col - sm - 6\")]//h3")));
                 }
             else
                 {
                     try
                     {
                         new WebDriverWait(driver, new TimeSpan(0, 0, timeout)).Until(
                             ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class,\"container\")]//h1")));
                     }
                     catch (Exception e)
                     {
                         Console.WriteLine(e);
                     }

                 }
             } */

        }



        public static void WaitUntilElementVisible(IWebDriver driver, By elementLocator, int timeout = 30)
        {
            new WebDriverWait(driver, new TimeSpan(0, 0, timeout)).Until(
                ExpectedConditions.ElementIsVisible(elementLocator));
        }


    }
}
