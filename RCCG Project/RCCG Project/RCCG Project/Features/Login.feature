Feature: Login
	So that i can use the site
	I need to login

@mytag
Scenario: Valid Login to a site
	Given I navigate to the site
	When I when i click login
	And I enter my email
	And I enter my password
	And I click on login button
	#Then I should be logged in
