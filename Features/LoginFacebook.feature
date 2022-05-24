Feature: LoginFacebook
	As a user of facebook 
	I want to login to facebook
	So that I can use my profile


Scenario: Verify Facebook Login
	Given I navigate to facebook.com
	When I enter username and password
	Then I click login button 
	And I enter to homepage of facebook
