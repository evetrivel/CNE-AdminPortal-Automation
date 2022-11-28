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

## Requirments :

### Environment: 
stage
### Launage: 
C#
### Open Source Tool for Automation:  
Selenium
### FrameWork: 
SpecFlow
### Tools : 
AutoIt

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

## Adding sample test scenarios

Feature:CNE_Creating new video in admin portal

Scenario Outline:  Add New Video in admin portal .

 -Given CNE admin portal page loaded succesfully. 
 
 -When Select select brand drop down button.
 
 -Then select "<Select brands>" in the list and verify brand logo.
        
 -And select Add New Video button.
        
 -And select schedule tab .
        
 -And select youtube and facebook check box.
        
 -And Select Save Button.
        
 -And verify error meaasge "O&O, YouTube, and Facebook".
        
 -And Select the cancel button..
        
 -And verify navigate back to home page.
        
 -Examples:
 -|Select brands|
 -|Acme Test Brand|
  
## Page Object Model :  
It is a design pattern in Selenium that creates an object repository for storing all web elements. 
  
## Steps definition file
  
  Steps definition file stores the mapping between each step of the scenario defined in the feature file with a code of function to be executed. So, now when Cucumber executes a step of the scenario mentioned in the feature file, it scans the step definition file and figures out which function is to be called.
  
 ### Feature File 
  
  It servers as an entry point to the Cucumber tests. It is the file where your test scenarios are written in Gherkin language. A Feature file may contain single or multiple test scenarios
  
 ### AppSettings 
  
  It stores strings or other values. It is found in a section of Web. config in an ASP.NET website project. We use this feature in the Web
  
  ### AutoIt 
  
  It is used in .exe format so that it can be used in the Selenium Automation script.

These include:
Set the focus to the current window.
Enter the path of the filename to upload in FileName Box.
Click on the Open button or Press Enter in Keyboard.
  
###  Wait Helper
  
  Selenium WebDriver provides three commands to implement waits in tests.
  
Implicit Wait.
Explicit Wait.
Fluent Wait.
