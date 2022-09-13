Feature: Store
In order to create an environment for managing store
As a user
I want to create, edit, detele, get store records

Scenario: Find order by orderId
Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'store/order/102'
When I do the get request
Then I should get the response as 200

Scenario: Find order by non-existing Id
Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'store/order/102'
When I do the get request
Then I should get the response as 404