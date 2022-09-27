Feature: Reverse String
As a user I want to input any string and get the revers string displayed.

Scenario: Reverse a string
	Given a string as <input>
	When enter or button is pressed
	Then a mirrored version of the input should be displayed as <reverse>
	Examples:
	| input   | reverse |
	| Jonas   | sanoJ   |
	| 1234    | 4321    |
	| ada     | ada     |
	| bertram | martreb |
	| linE    | Enil    |

Scenario: Limit a string to a max number of characters
	Given  a string as <input>
	When the string is above <char_length>
	Then a limited version of the string should be <reversed>
	Examples: 
	| input	  | char_length | reversed  |
	| Jonas   |      0      |			|
	| 1234    |      1      | 4			|
	| ada     |      2      | ad        |
	| bertram |      3      | mar		|
	| linE    |      20     | Enil      |