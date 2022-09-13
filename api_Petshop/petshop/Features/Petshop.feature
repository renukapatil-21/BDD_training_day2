Feature: Petshop
  In order to create an environment for managing pet shop
  As a user
  I want to create, edit, delete, get pet details

Scenario: Find Pet By PetId
  Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/102'
  When I do the Get Request
  Then I should get a response as 200
  And I should get the details of pet in json format

Scenario: Find Pet By Invalid PetId
  Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/-102'
  When I do the Get Request
  Then I should get a response as 400
  And I should get a message as 'Invalid ID supplied'

Scenario: Find Pet By PetId which is not Present
  Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/1002'
  When I do the Get Request
  Then I should get a response as 404
  And I should get a message as 'Pet not found'

Scenario: Delete pet by petId
      Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/105'
      And I need add api_key 'Ak888' in the header
      When I do the delete request
      Then I should get the response as 200

Scenario: Delete pet by invalid petId
      Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/-102'
      And I need add api_key 'Ak888' in the header
      When I do the delete request
      Then I should get the response as 400
      And I should get a message as 'Invalid ID supplied'

Scenario: Delete pet by non-existing petId
      Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/1102'
      And I need add api_key 'Ak888' in the header
      When I do the delete request
      Then I should get the response as 404
      And I should get a message as 'Pet not found'
