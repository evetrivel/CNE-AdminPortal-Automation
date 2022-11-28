
Feature: CneBrandSettings
@Regression

#Scenario: 01 Successful Login into CNE admin Portal with Valid Credentials 
#Given CNE admin portal page loaded succesfully
#When enter username "eniyan_vetrivel@condenast.com" and select Next button
#Then enter password "Welcome@2022" and select signIn Button to login page
#And select SendPush button
#And verify page is navigated into Admin portal homepage  


#Brand YouTube Channels - 2
Scenario Outline: 02 Add Brand YouTube Channels in brand settings
Given CNE admin portal page loaded succesfully
When select YouTube Channels in left side window of homepage
Then select the Add YouTube Channels button 
And enter value in "<Channel Name>" Channel name
And enter value in "<Channel ID>" channel id
And enter value in "<Content Owner ID>" Owner id
And select the save button
And Verify the error msg in YT page "<Channel Name>"
Examples:
|Channel Name|Channel ID|Content Owner ID|
||||
|eni|12|34|



Scenario: 03 Edit and delete Brand YouTube Channels
Given CNE admin portal page loaded succesfully
When select YouTube Channels in left side window of homepage
Then select any Brand YouTube Channels title in the list of YouTube Channels
And enter value in "69" channel id
And select the save button
And select the delete button



#Brand Facebook Pages - 2
Scenario Outline: 04 Add Brand Facebook Pages
Given CNE admin portal page loaded succesfully
When select Facebook Pages in left side window of homepage
Then select the Add Facebook Pages button 
And enter value in "<Page Name>" page name
And enter value in "<Page ID>" page id 
And select the save button
And Verify the error msg in Fb page "<Page Name>"
Examples:
|Page Name|Page ID|
|||
|eni|12|



Scenario: 05 Edit and delete Brand Facebook Pages
Given CNE admin portal page loaded succesfully 
When select Facebook Pages in left side window of homepage
Then select any Brand Facebook Pages title in the list of Facebook Pages
And enter value in "69" page id
And select the save button
And select the delete button
