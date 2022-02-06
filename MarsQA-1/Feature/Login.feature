Feature: As a seller I would like to add profile detaila so that people
         seeking for some skills can look in to my details

Scenario:: Profile creation
	Given I am on my Profile Page
	When I Click Addnew Language with valid details
	And  :I Click  Add new Skills with valid credentials
	And : I Click Add new Education with valid credentials
	And  :I Click Andd new Certifications with valid credentials
	Then Profile page is created successfully


 