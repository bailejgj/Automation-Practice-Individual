Feature: ProceedToRegisterPage
	To get a personal experience
	As a user
	I want to register an account

@mytag
Scenario: ProceedToRegisterPageWithValidEmail
	Given I am on the SignInPage
	And I have entered a valid email address
	When I click create account
	Then I am redirected to the RegisterPage