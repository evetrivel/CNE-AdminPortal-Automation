﻿@Regression
Feature: CnePlayerSettings


#Scenario: 01 Successful Login into CNE admin Portal with Valid Credentials 
#Given CNE admin portal page loaded succesfully
#When enter username "username" and select Next button
#Then enter password "password" and select signIn Button to login page
#And enter Q&A "Q&A" and select Verify button
#And select SendPush button
#And verify page is navigated into Admin portal homepage   

#Player settings - 1

Scenario: 02 Player settings Blacklist Sites
Given CNE admin portal page loaded succesfully
When select Player settings Blacklist Sites in left side window of homepage
Then Enter "1abs.com" value in domain
And Select Add blacklist site button exsist
And Select delete button in Blacklist
And Select delete ok button 