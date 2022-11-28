
Feature: CneGlobalSettings
@Regression

#Scenario: 01 Successful Login into CNE admin Portal with Valid Credentials 
#Given CNE admin portal page loaded succesfully
#When enter username "eniyan_vetrivel@condenast.com" and select Next button
#Then enter password "Welcome@2022" and select signIn Button to login page
#And select SendPush button
#And verify page is navigated into Admin portal homepage  

#Gobal settings - 4

Scenario: 02 Gobal settings brands
Given CNE admin portal page loaded succesfully
When select Gobal settings brands in left side window of homepage
Then verify env_URL link are working 
| input_fields         |
| Production      |
| Staging         |
| Sandbox         |
| Portal Settings |
And select any brand title
And verify its naviagting into Edit Brand page
And verify the save button exsist



Scenario: 03 Gobal settings Configuration 
Given CNE admin portal page loaded succesfully
When select Gobal settings Configuration in left side window of homepage
Then verify the Gobal settings Configuration page
And verify Submit button exsist


Scenario Outline: 04 Gobal settings Content Libraries
Given CNE admin portal page loaded succesfully
When select Gobal settings Content Libraries in left side window of homepage
Then Select the Gobal settings Content Libraries 
And Enter  value in name
| input_fields |
|              |
| ATest        |
And Enter "Tester" value in Approvedby
And Select "<contentselect>" value 
And select the save button Content
#And select edit button recent 
#And Enter "TesterConde" value in Approvedby
#And select the save button Content
Examples:
| contentselect |
| audio         |
| image         |
| video         |




Scenario: 05 Gobal settings Top Level Categories
Given CNE admin portal page loaded succesfully
When select Gobal settings Top Level Categories in left side window of homepage
Then Verify save order button
And select the edit button
And verify Edit CNE Category fields are editable 
And verify the save button

