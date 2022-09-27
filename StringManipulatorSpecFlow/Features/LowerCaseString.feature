Feature: Lowercase String

As a user I want to input any string and get a lowercase version of the string displayed.

Scenario: Lowercase a string
	Given a string as <input>
	When enter or button is pressed
	Then a mirrored version of the input should be displayed as <lowercase>
	Examples:
	| input   | lowercase |
	| Jonas   | jonas   |
	| 1234    | 1234    |
	| ada     | ada     |
	| bertram | bertram |
	| linE    | line    |