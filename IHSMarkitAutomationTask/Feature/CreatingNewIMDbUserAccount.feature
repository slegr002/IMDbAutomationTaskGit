Feature: CreatingNewIMDbUserAccount
	As a IMDb User
	I want to be able to Create a New User Account and Login to Account

@Scenario1
Scenario: Create New Account 
	Given I am in the Create New Account Page 
	When I fill out input fields with the user name 'Sebastien', email 'slegr002@fiu.edu', password 'Test1', reentered password 'Test1'
		And Click the CreateYourIMDbAccount button
	Then A new user account is created with user name 'Sebastien', email 'slegr002@fiu.edu', password 'Brasil_12', reentered password 'Test1'

