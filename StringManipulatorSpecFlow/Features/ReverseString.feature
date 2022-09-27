Feature: Reverse String
As a user I want to input any string and get the revers string displayed.

Scenario: Reverse a string
	Given a string as <input>
	| input   |
	| Jonas   |
	| 1234    |
	| ada     |
	| bertram |
	| linE    |
	When enter or button is pressed
	Then a mirrored version of the input should be displayed in <reverse>
	| reverse |
	| sanoJ   |
	| 4321    |
	| ada     |
	| martreb |
	| Enil    |

Scenario: Limit a string to a max number of characters
	When the string is above <char_length>
	| char_length |
	| 0           |
	| 1           |
	| 2           |
	| 3           |
	| 20          |
	Then a limited version of the string should be displayed <limited_reverse> 
	| limited_reverse |
	|			      |
	| 1			      |
	| ad              |
	| reb		      |
	| Enil            |