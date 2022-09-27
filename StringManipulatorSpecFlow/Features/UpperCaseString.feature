Feature: Uppercase String

As a user I want to input any string and get a uppercase version of the string displayed.

Scenario: Uppercase a string
	Given a string as <somecase>
	| somecase |
	| Jonas    |
	| 1234     |
	| ada      |
	| bertram  |
	| linE     |
	When enter or toUpperButton is pressed
	Then a mirrored version of the input should be displayed as <uppercase>
	| uppercase |
	| JONAS     |
	| 1234      |
	| ADA       |
	| BERTRAM   |
	| LINE      |