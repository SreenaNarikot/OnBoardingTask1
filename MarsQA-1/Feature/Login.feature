Feature: As a seller I would like to add profile detaila so that people
         seeking for some skills can look in to my details

Scenario:: ProfileLanguage creation
	Given I am on my Profile Page
	When I Click Addnew Language with valid details
	Then Profile page is created successfully