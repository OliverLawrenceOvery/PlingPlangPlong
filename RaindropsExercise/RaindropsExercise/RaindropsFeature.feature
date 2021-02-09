Feature: RaindropsFeature
	Utility for giving a certain concatenated output given if the input has factors of 3, 5 and/or 7

@mytag
Scenario: A number has a single factor out of 3, 5 and 7
	Given I input a number <input1> which has a single factor
	When the factor finder method is called
	Then the result is the appropriate string <result>
	Examples:
	| input1 | result  |
	| 3      | "Pling" |
	| 6      | "Pling" |
	| 5      | "Plang" |
	| 10     | "Plang" |
	| 7      | "Plong" |
	| 14     | "Plong" |