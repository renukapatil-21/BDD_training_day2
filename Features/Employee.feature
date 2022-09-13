Feature: Employee
		In order to add employee to the portal 
		as a admin
		I want to add records  to the portal

@high
Scenario Outline: Add valid Employee
	Given I have browser with orangehrm page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	And I click on PIM
	And I click on Add Employee
	And I fill the add Employee section
		| firstname | middlename | lastname | employee_id | toggle_login_detail | username | password    | confirm_password | status  |
		| <firstname>     |   <middlename>      |  <lname> | <empid>        | <toggle_login>                | <account_user>   | <account_password> | <confirm_password>      | <status> |
	And I click on save employee
	Then I should to navigated to personal details section with added employee records

Examples: 
		 | username | password | firstname | middlename | lname   | empid | toggle_login | account_user | account_password | confirm_password | status   |
		 | admin    | admin123 | Saul      | J          | Goodman | 1005  | on           | jimmy13      | Welcome@123      | Welcome@123      | disabled |
		 | admin    | admin123 | Peter     | J          | Goodman | 1006  | on           | peter13      | Welcome@123      | Welcome@123      | disabled |