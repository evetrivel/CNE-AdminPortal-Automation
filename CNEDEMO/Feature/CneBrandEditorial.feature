Feature: BrandEditorial

@Regression
Scenario: 01 Successful Login into CNE admin Portal with Valid Credentials 
Given CNE admin portal page loaded succesfully
When enter username "eniyan_vetrivel@condenast.com" and select Next button
Then enter password "Welcome@2022" and select signIn Button to login page
And select SendPush button
And verify page is navigated into Admin portal homepage  


#Series and season 

Scenario: 02 Add New series in admin portal 
Given CNE admin portal page loaded succesfully  
When select Series&season in left side window of homepage
Then verify Save order button exist
And select Add New Series button
#And verify navigating into New Series detials data page 
And Enter value in "TestReg" in new series
And select create button
And verify created Season is exsist
And Enter value in SeriesCategories "test" in seriespage
And select update button

Scenario: 03 Negative scenario Add New series in admin portal 
Given CNE admin portal page loaded succesfully  
When select Series&season in left side window of homepage
Then verify Save order button exist
And select Add New Series button 
And Enter value in "" in new series
And select create button
And verify error msg




Scenario: 04 Rearrange the order series by drage n drop in series&season page
Given CNE admin portal page loaded succesfully
When select Series&season in left side window of homepage
Then verify save order buttton
#And Rearrange the order in Series list by drag and drop
And Select save order Button


Scenario: 05 update series and add season in series&season edit page
Given CNE admin portal page loaded succesfully 
When select Series&season in left side window of homepage
Then select edit series or Title of the series
And select Add season button  
And enter basic season title "Season 2" value 
#And select upload poster frame
#And verify basic create button
And select host catagory 
And enter host title "test" value
And select hostintro value in dropdown
#And select upload hostimage 
And verify host create button
And select episodes catagory
And verify episode create button
And select credit catagory
And enter maincredits name "testmaincredits" value 
And select maincredits celebrity value in dropdown
And select maincredits addnew button
And remove newly added maincredits name value 
And enter Featured credits name "testFeatured" value 
And select Featured credits celebrity value in dropdown
And select Featured credits addnew button
And remove newly addedFeatured credits name value
And enter directorcredits name "testdirectorcredits" value 
And select directorcredits celebrity value in dropdown
And select directorcredits addnew button
And remove newly addeddirectorcredits name value
And enter productioncredits name "testproductioncredits" value 
And select productioncredits productionrole value in dropdown
And select productioncredits addnew button
And remove newly addedproductioncredits name value 
And enter videorgrapher "testvg" value
And select videorgrapher addnew button
And remove newly added videographer name value
And enter legalcredits name "testlegalcredits" value 
And select credit create button
And verfiy newly created season
And verify newly created season delete button
And select newly created season edit button 
And enter basic tag "test" value 
And select update season button 

Scenario: 06 Nagetive scenario update series and add season in series&season edit page
Given CNE admin portal page loaded succesfully 
When select Series&season in left side window of homepage
Then select edit series or Title of the series
And select Add season button  
And enter basic season title "" value 
And verify error msg in season page




Scenario: 07 Add new playlist
Given CNE admin portal page loaded succesfully 
When select Playlists in left side window of homepage
Then select the addnew buttton
And enter 'Atestxyz' Title in Tttle for New Playlists box
And select OK button
And verify newly added playlist
And verify playlistsActiveSubcarousel Button


Scenario: 08 Active/non active/programing playlist
Given CNE admin portal page loaded succesfully 
When select Playlists in left side window of homepage
Then select the [not selected] dropdpwn list
#And verify Active/non active/programing are exsist
And select Active in the list
And verify the result of Active  playlist
And select non active in the list
And verify the result of non active playlist
And select programing in the list
And verify the result of programing playlist


Scenario: 09 Edit playlist
Given CNE admin portal page loaded succesfully 
When select Playlists in left side window of homepage
Then select view playlist
And verify generateslug button exsist 
And verify SqaurePreview button exsist 
And verify CoustmizedEmbed button exsist 
And verify BranddropDown button exsist 
And verify Sponsored check box  exsist 
And verify AddVideo button exsist 
And verify the delete button exsist
And select ActiveplaylistsCheckBox Button
And select image to upload
And select the save button exsist
Then select view playlist
And Select delete button


#Watch Page Promotional Links - 1
#
#Scenario: 08 verify the links in Watch Page Promotional Links
#Given CNE admin portal page loaded succesfully
#When select Watch Page in left side window of homepage
#Then verify six links go on the bottom of each watch page
#And verify edit button exsist
#And select the edit button 
#And verify the close and save button exsist
#And verify all field are editable in edit link 



#Email lists - 4



Scenario Outline: 10 Add and delete CaptionAlerts Email lists
Given CNE admin portal page loaded succesfully
When select Email lists in left side window of homepage
Then enter "<email id>" in CaptionAlerts email box editable
And select Add button exsist
And select "<email id>" delete button
And verify "<email id>" error msg in emaillist
Examples:
| email id |
|eni.com|
|eniyan@gmail.com|
|eniyan@gmail|
|@gmail.com|


Scenario Outline: 11 Add and delete PublishedToday Email lists
Given CNE admin portal page loaded succesfully 
When select Email lists in left side window of homepage
Then enter "<email id>" in PublishedToday email box editable
And select Add button exsist in PublishedToday
And select "<email id>" PublishedToday delete button
And verify "<email id>" error msg in emaillist
Examples:
| email id |
|eni.com|
|eniyan@gmail.com|
|eniyan@gmail|
|@gmail.com|


Scenario Outline: 12 Add and delete VideoAlerts Email lists
Given CNE admin portal page loaded succesfully 
When select Email lists in left side window of homepage
Then enter "<email id>" in VideoAlerts email box editable
And select Add button exsist in VideoAlerts
And select "<email id>" VideoAlerts delete button
And verify "<email id>" error msg in emaillist
Examples:
| email id |
|eni.com|
|eniyan@gmail.com|
|eniyan@gmail|
|@gmail.com|


