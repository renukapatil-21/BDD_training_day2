Feature: Emergency contact 
			In order to reach the employee relation on emergency
			As an admin
			I should have access to add, edit, delete employee emergency contact

Scenario Outline: Add Emergency Contact
	Given Given I have browser with login page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	And I click on My Information
	And I click on Emergency contacts
	And I click on Add
	And I fill the Emergency contact details
			| name | relationship | home_telephone | work_telephone | mobile     |
			| <relative_name> | <relation>       | <home_tele>     | <work_tele>     | <mob> |
	And I click on save 
	Then I should to navigated to view emergency contacts and verify the contact

	Examples: 
					| username | password  | relative_name | relation | home_tele | work_tele | mob    |
					| admin    | admin@123 | riya          | sister   | 6872368   | 2536321   | 524615 |
					| admin    | admin@123 | shriya        | sister   | 6872368   | 2536321   | 524615 |
