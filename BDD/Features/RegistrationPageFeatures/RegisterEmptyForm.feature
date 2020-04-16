Feature: RegisterEmptyForm
	In order to avoid silly mistakes
	As a developer
	I want to receive an error when an empty register form is submitted

@mytag
Scenario: RegisterEmptyForm
	Given I am on the register page
	And I enter no details
	When I press register
	Then I receive 8 errors
