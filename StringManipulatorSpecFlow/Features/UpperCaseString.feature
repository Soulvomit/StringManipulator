Feature: Uppercase
As a user I want to input any string and get a uppercase version of the string displayed.

Scenario: Uppercase a string
	Given a input string
	| anycase   |
	| <anycase> |
	When enter or toUpperButton is pressed
	Then a uppercase version of the input should be displayed
	| uppercase   |
	| <uppercase> |
	Examples:
	| anycase | uppercase |
	| Jonas   | JONAS     |
	| 1234    | 1234      |
	| ada     | ADA       |
	| bertram | BERTRAM   |
	| linE    | LINE      |