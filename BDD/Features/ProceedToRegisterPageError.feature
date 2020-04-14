Feature: ProceedToRegisterPageError
	To get a secure experience
	As a user
	I want to get an error if I enter an invalid email

@newtag
Scenario: GetErrorWhenRegisterWithInvalidEmail
	Given I am on the SigInPage
	And I have entered an email without an at sign
	When I click create account
	Then I am given the error "Invalid email address."