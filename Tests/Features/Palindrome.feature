Feature: Palindrome

Scenario Outline: Palindrome String
	When I check if '<word>' is a palindrome
	Then the bool result is <result>

	Examples:
	| word  | result |
	| abba  | true   |
	| abab  | false  |
	| AbbA  | true   |
	| AbCbA | true   |
	| AbBA  | false  |
	| ABCba | false  |

Scenario Outline: Palindrome Number
	When I check if <number> is a palindrome
	Then the bool result is <result>

	Examples:
	| number  | result |
	| 12321   | true   |
	| 12345   | false  |
	| 1221    | true   |
	| 1231    | false  |
	| 2		  | true   |

Scenario Outline: Palindrome Byte Array
	When I check if byte array <number> is a palindrome
	Then the bool result is <result>

	Examples:
	| number   | result |
	| 12,34,12 | true   |
	| 12,34,13 | false  |
	| 12,12    | true   |
	| 12,13    | false  |
	| 12       | true   |
	| 1,0,1    | true   |
	| 1,0      | false  |

Scenario Outline: Palindrome Byte List
	When I check if byte list <number> is a palindrome
	Then the bool result is <result>

	Examples:
	| number   | result |
	| 12,34,12 | true   |
	| 12,34,13 | false  |
	| 12,12    | true   |
	| 12,13    | false  |
	| 12	   | true   |
	| 1,0,1    | true   |
	| 1,0      | false  |