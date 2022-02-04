Feature: As a seller I would like to add profile detaila so that people
         seeking for some skills can look in to my details

@mytag
Scenario: Add new profile with valid details
	Given : I logged into the URL succsfully
	And : I navigate to profilepage
	When : I add new profile record
	Then :The profile record should be added succsfully
