Feature: Invalid Login Scenerios
	In order to make sure we`ve covered most test
	We need to run some scenerios on Invalid Logins
	

@mytag
Scenario: Invalid Login to a Site
	Given I navigate to the site
	When I click on Login link
	And I enter a valid Username
	And I enter an invalid Password
	And I click on the Login button
	Then I should not be logged in

	Scenario: Invalid Login to a Site
	Given I navigate to the site
	When I click on Login link
	And I enter an invalid Username
	And I enter a valid Password
	And I click on the Login button
	Then I should not be logged in

	Scenario: Invalid Login to a Site
	Given I navigate to the site
	When I click on Login link
	And I enter an invalid Username
	And I enter an invalid Password
	And I click on the Login button
	Then I should not be logged in

	Scenario: Invalid Login to a Site
	Given I navigate to the site
	When I click on Login link
	And I enter a blank Username
	And I enter a blank Password
	And I click on the Login button
	Then I should not be logged in

	Scenario: Invalid Login to a Site
	Given I navigate to the site
	When I click on Login link
	And I enter a blank Username
	And I enter a valid Password
	And I click on the Login button
	Then I should not be logged in

	Scenario: Invalid Login to a Site
	Given I navigate to the site
	When I click on Login link
	And I enter a valid Username
	And I enter a blank Password
	And I click on the Login button
	Then I should not be logged in

	Scenario: Invalid Login to a Site
	Given I navigate to the site
	When I click on Login link
	And I enter a blank Username
	And I enter an Invalid Password
	And I click on the Login button
	Then I should not be logged in

	Scenario: Invalid Login to a Site
	Given I navigate to the site
	When I click on Login link
	And I enter an invalid Username
	And I enter a blank Password
	And I click on the Login button
	Then I should not be logged in

	