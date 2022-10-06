Feature: Reverse
As a user I want to input any string and get the revers string displayed.

Scenario: Reverse
	Given a string
	| input   |
	| <input> |
	When enter or button is pressed
	Then a mirrored version of the input should be displayed
	| reversed   |
	| <reversed> |
	Examples: 
			| input   | reversed |
			| Jonas   | sanoJ    |
			| 1234    | 4321     |
			| ada     | ada      |
			| bertram | martreb  |
			| linE    | Enil     |

Scenario: Limit
	Given a string
	| input   |
	| <input> |
	When the string is above character limit
	| char_length   |
	| <char_length> |
	Then a limited and mirrored version of the string should be displayed
	| limited_reversed   |
	| <limited_reversed> |
	Examples: 
			| input   | char_length | limited_reversed |
			| Jonas   | 0           |                  |
			| 1234    | 1           | 1                |
			| ada     | 2           | da               |
			| bertram | 3           | reb              |
			| linE    | 20          | Enil             |
