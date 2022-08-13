Feature: Prime

Scenario Outline: Prime Numbers
	When I check if <value> is prime
	Then the prime result is <truthiness>

	Examples:
	| value | truthiness |
	| 2     | true       |
	| 9     | false      |
	| 41    | true       |
	| 410   | false      |

Scenario Outline: Composite Numbers
	When I check if <value> is composite
	Then the prime result is <truthiness>

	Examples:
	| value | truthiness |
	| 2     | true       |
	| 9     | false      |
	| 41    | true       |
	| 410   | false      |

Scenario Outline: Largest Prime Factor
	When I get the largest prime factor of <seed>
	Then the answer is <answer>

	Examples:
	| seed    | answer |
	| 25      | 5      |
	| 508     | 127	   |
	| 4411200 | 919    |

Scenario Outline: Sum Of Divisors
	When I get the sum of divisors of <seed>
	Then the answer is <answer>

	Examples:
	| seed | answer |
	| 220  | 284    |
	| 284  | 220    |
	| 125  | 31     |