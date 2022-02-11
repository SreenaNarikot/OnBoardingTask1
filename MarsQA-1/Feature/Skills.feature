Feature: Creating the Skills in the Profile page with valid credentials




Scenario Outline: Creating a new Skills details
	Given : I am on my Profile Page
	When :I click new skills with valid '<skill>' and '<level>' details
	Then :The Skills details with '<skill>' and '<level>' will be created successfully.
Examples:
| skill    | level    |
| Graphics | Beginner |
| Python   | Expert   |




