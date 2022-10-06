Feature: Lowercase
As a user I want to input any string and get a lowercase version of the string displayed.

Scenario: Lowercase a string
	Given a input string
	| anycase   |
	| <anycase> |
	When enter or toLowerbutton is pressed
	Then a lowercase version of the input should be displayed
	| lowercase   |
	| <lowercase> |
	Examples:
	| anycase | lowercase |
	| Jonas   | jonas     |
	| 1234    | 1234      |
	| ada     | ada       |
	| bertram | bertram   |
	| linE    | line      |