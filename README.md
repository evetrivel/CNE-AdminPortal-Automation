```
  _____                _   __   _   _           _
 / ____|              | | /_/  | \ | |         | |
| |     ___  _ __   __| | ___  |  \| | __ _ ___| |_
| |    / _ \| '_ \ / _` |/ _ \ | . ` |/ _` / __| __|
| |___| (_) | | | | (_| |  __/ | |\  | (_| \__ \ |_
 \_____\___/|_| |_|\__,_|\___| |_| \_|\__,_|___/\__|
```

# CNE Admin Portal

Adminportal is our CMS for all brand and partner videos, series, video groups.It has around 70+ test scenarios and covers it up all in automation by using c# selenium   

### Requirments :

#### Environment: 
stage
#### Launage: 
C#
#### Open Source Tool for Automation:  
Selenium
#### FrameWork: 
SpecFlow
#### Tools : 
AutoIt , Visual Studio

## Test automation project configuration

### Setting up Specflow

The section is mainly based on official setup guide for Specflow. Code under test was slightly modified to make more space for several test scenarios to take place, in order to demonstrate different aspects of Report Portal integration with Specflow framework. The official guide is located at: https://specflow.org/getting-started.

Follow the official guide to create a basic project with the test framework applied, finishing after "Adding a SpecFlow Profile" section done. Once steps completed the project should fit these conditions:

1. The following packages are installed:
- Microsoft.NETCore.App (pre-installed for .NET Core apps)
- Microsoft.NET.Test.Sdk (pre-installed for test projects)
- MSTest.TestFramework (pre-installed for MSTest Test Project)
- SpecFlow
- SpecFlow.Tools.MsBuild.Generation
- SpecRun.SpecFlow

Note each test project created with VS wizard has a test runner pre-installed (MSTest.TestAdapter in the case of MSTest project). Uninstall it since Specflow provided one will be used instead in the guide.

 ### Feature File 
  
  It servers as an entry point to the Cucumber tests. It is the file where your test scenarios are written in Gherkin language. A Feature file may contain single or multiple test scenarios
  
## Adding sample test scenarios


*Cne.feature*

```Gherkin
Feature: Ad Creatives in admin portal

Scenario: 02 ADVERTISING Ad_creatives
Given CNE admin portal page loaded succesfully
When select ADVERTISING lists in left side window of homepage
Then Enter creative name "BMWlogo"
And select search  button in creative
And select clear button in creative
And select Add new creative button
And select create creative button
And verify creative error msg
And select cancel button
And select Editmidea button
And verify upload image file 
And select leave page button
And select recent Add link
And select Mideo URl 

```
## Page Object Model :  
It is a design pattern in Selenium that creates an object repository for storing all web elements. 
```C#
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CNEDEMO.PageObject
{
    public class CneAdvertisingsPage
    {
        IWebDriver driver;
        public CommonPage commonPage;

        public CneAdvertisingsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Advertising = "//div[@class = 'cn-body container-fluid']//a[text()='Ad Creatives']";
        public string SearchBox = "//div[@class = 'cn-body container-fluid']//input[@id='search-input']";

    }
}
```

## Steps definition file
  
  Steps definition file stores the mapping between each step of the scenario defined in the feature file with a code of function to be executed. So, now when Cucumber executes a step of the scenario mentioned in the feature file, it scans the step definition file and figures out which function is to be called.
  
  ```C#
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
    public sealed class CneAdvertisingsteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        public CommonPage commonPage;
        // public CommonSteps commonSteps;

        public CneAdvertisingsteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = CommonSteps.driver;
        public CneAdvertisingsPage CneAdvertisingsPage;

        [When(@"select ADVERTISING lists in left side window of homepage")]
        public void WhenSelectADVERTISINGListsInLeftSideWindowOfHomepage()
        {
            CneAdvertisingsPage = new CneAdvertisingsPage(driver);
            CommonPage commonPage = new CommonPage(driver);
            CommonPage.ClickableElement(driver, CneAdvertisingsPage.Advertising);
        }
        
      }
        
}
``` 
 ### AppSettings 
  
  It stores strings or other values. It is found in a section of Web. config in an ASP.NET website project. We use this feature in the Web
  
  ```C#
  {
  "url": "https://admin-staging.cnevids.com/",
  "username": "eniyan_vetrivel@condenast.com",
  "password": "Welcome@2022"
}

```  


  
### AutoIt 
  
  It is used in .exe format so that it can be used in the Selenium Automation script.

These include:
Set the focus to the current window.
Enter the path of the filename to upload in FileName Box.
Click on the Open button or Press Enter in Keyboard.

  ```C#
          var processinfo = new ProcessStartInfo()
          {
               FileName = @"C:\Users\evetrivel\Downloads\File+Upload\FileUpload.exe",
                Arguments = @"C:\Users\evetrivel\Downloads\Screenshots-20220808T062405Z-001\Screenshots\frame.jpg"
            };

            using (var process = Process.Start(processinfo))
            {
                process.WaitForExit();
            }
``` 
  
###  Wait Helper
  
  Selenium WebDriver provides three commands to implement waits in tests.
  
Implicit Wait.
Explicit Wait.
Fluent Wait.
  ```C#
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
            
         }
      }
 }     
``` 
