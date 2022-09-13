Feature: login
			In order to maintain the employee records
			As a user
			I want to login into portal

@high
Scenario: Valid Credetials
	Given I have browser with orangehrm page
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	Then I should be navigate to 'PIM' dashboard screen

Scenario Outline: Invalid Credetials
	Given I have browser with orangehrm page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	Then I should get error page as '<error message>'
Examples:
	| username | password | error message       |
	| john     | john123  | Invalid credentials |
	| saul     | saul123  | Invalid credentials |