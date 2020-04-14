Feature: NavigateToLogin
	In order to enjoy a personal experience
	As a user
	I want to be told navigate to the signin page

@mytag
Scenario: Navigate to SignIn
	Given I am on the HomePage
	When I press signin
	Then I am redirected to the SignIn