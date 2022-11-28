@Regression
Feature: CneAdvertisings

#Scenario: 01 Successful Login into CNE admin Portal with Valid Credentials 
#Given CNE admin portal page loaded succesfully
#When enter username "eniyan_vetrivel@condenast.com" and select Next button
#Then enter password "Welcome@2022" and select signIn Button to login page
#And select SendPush button
#And verify page is navigated into Admin portal homepage  

# 1 scenario

Scenario: 02 ADVERTISING Aad_creatives
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