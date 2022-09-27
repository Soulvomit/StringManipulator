Feature: Lowercase String

As a user I want to input any string and get a lowercase version of the string displayed.

Scenario: Lowercase a string
	Given a string as <input>
	| input   |
	| Jonas   |
	| 1234    |
	| ada     |
	| bertram |
	| linE    |
	When enter or button is pressed
	Then a mirrored version of the input should be displayed as <lowercase>
	| lowercase |
	| jonas     |
	| 1234      |
	| ada       |
	| bertram   |
	| line      |