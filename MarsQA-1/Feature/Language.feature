Feature: Creating the Language in the Profile page with valid credentials



Scenario Outline: 1.Creating a new Language details
	Given : I am on my Profile Page
	When  : I click new language with valid '<language>' and '<level>' details
	Then : The Language details with '<language>' and '<level>' will be created successfully.


Examples: 
          | language | level  |
          | English  | Basic  |
          | French   | Fluent |

Scenario Outline: 2.Reading the record created for Language
Given : I am on my Profile Page
When : I Click Language
Then :Record must have been created with <count> records successfully
Examples: 
| count |
| 2     |

Scenario Outline: 3.Editing languges that has been created
Given : I am on my Profile Page
When :I click update the record with  new '<language>' and '<level>'
Then : the Record should have been edited successfully .
Examples: 
| language | level  |
| Java     | Fluent |
| Python   | Basic  |

