Feature: AddingANewAddress
	In order to allow my account to stay up to date
	As a user with multiple homes
	I want to be able to add a new address

@mytag
Scenario: AddingNewAddress
	Given I have signed in
	And I am on the address page
	When I press Add a New Address
	Then I am redirected to a new address page
