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

Scenario Outline: Fibonacci Numbers
	When I get the fibonacci number of <seed>
	Then the fibonacci number is <value>

	Examples:
	| seed | value |
	| 1    | 1     |
	| 6    | 8     |
	| 10   | 55    |

Scenario Outline: Fibonacci Sequence
	When I get the fibonacci sequence of <seed>
	Then the fibonacci sequence is <sequence>

	Examples:
	| seed | sequence                  |
	| 1    | 0,1                       |
	| 6    | 0,1,1,2,3,5,8			   |
	| 10   | 0,1,1,2,3,5,8,13,21,34,55 |

Scenario Outline: Palindrome
	When I check if <word> is a palindrome
	Then the bool result is <result>

	Examples:
	| word  | result |
	| abba  | true   |
	| abab  | false  |
	| AbbA  | true   |
	| AbCbA | true   |
	| AbBA  | false  |
	| ABCba | false  |