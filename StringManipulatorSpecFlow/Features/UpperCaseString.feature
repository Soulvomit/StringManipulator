Feature: Uppercase String

As a user I want to input any string and get a uppercase version of the string displayed.

Scenario: Uppercase a string
	Given a string as <input>
	When enter or button is pressed
	Then a mirrored version of the input should be displayed as <uppercase>
	Examples:
	| input   | uppercase |
	| Jonas   | JONAS   |
	| 1234    | 1234    |
	| ada     | ADA     |
	| bertram | BERTRAM |
	| linE    | LINE    |