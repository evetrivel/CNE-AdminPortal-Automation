@Regression
Feature: CneTools


#Scenario: 01 Successful Login into CNE admin Portal with Valid Credentials 
#Given CNE admin portal page loaded succesfully
#When enter username "username" and select Next button
#Then enter password "password" and select signIn Button to login page
#And enter Q&A "Q&A" and select Verify button
#And select SendPush button
#And verify page is navigated into Admin portal homepage  


#Tool - 1 scenario

Scenario: 02 Tools Report
Given CNE admin portal page loaded succesfully
When select Report lists in left side window of homepage
Then Select csv 
And select Link