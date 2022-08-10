Feature: Utilities

Scenario Outline: Factorial
	When I get the factorial of <seed>
	Then the factorial is <factorial>

	Examples:
	| seed | factorial           |
	| 0    | 1                   |
	| 1    | 1                   |
	| 5    | 120                 |
	| 10   | 3628800             |
	| 20   | 2432902008176640000 |

Scenario Outline: Collatz Sequence
	When I get the length of the collatz sequence of <seed>
	Then the length of the collatz sequence is <length>

	Examples: 
	| seed      | length |
	| 1         | 1      |
	| 11        | 15     |
	| 111       | 70     |
	| 1111      | 32     |
	| 11111     | 56     |
	| 111111    | 116    |
	| 1111111   | 166    |
	| 11111111  | 110    |
	| 111111111 | 165    |

# TODO: Combinatorics tests