Feature: CompleteRegistrationSteps
	In order to personalise my experience
	As a user
	I want to be register my details

@mytag
Scenario: Complete Registration
	Given I am on the register page
	And I have entered valid values into all fields
	When I press register
	Then I am redirected to the my account page
