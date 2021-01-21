Feature: SignInToIMDbAccount
	As a IMDb User
	I want to be able to Login to Account

@Scenario1	
Scenario: Login to Account
	Given I am in the Sign In page
	When I enter user email 'slegr002@fiu.edu'
		And I enter user password 'Brasil_12'
		And I click on the Sign In button
	Then I'm signed in to user account for 'Sebastien'