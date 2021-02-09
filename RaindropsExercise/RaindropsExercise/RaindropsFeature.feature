Feature: RaindropsFeature
	Utility for giving a certain concatenated output given if the input has factors of 3, 5 and/or 7

@mytag
Scenario: A number has a single factor out of 3, 5 and 7
	Given I input a number which has a single factor
	When the factor finder method is called with <input1>
	Then the result is the appropriate string <result>
	Examples:
	| input1 | result  |
	| 3      | Pling |
	| 6      | Pling |
	| 5      | Plang |
	| 10     | Plang |
	| 7      | Plong |
	| 14     | Plong |
	| -3      | Pling |
	| -6      | Pling |
	| -5      | Plang |
	| -10     | Plang |
	| -7      | Plong |
	| -14     | Plong |

@mytag
Scenario: A number has a two factors out of 3, 5 and 7
	Given I input a number which has two factors
	When the factor finder method is called with <input1>
	Then the result is the appropriate string <result>
	Examples:
	| input1  | result     |
	| 15      | PlingPlang |
	| 21      | PlingPlong |
	| 35      | PlangPlong |
	| -15      | PlingPlang |
	| -21      | PlingPlong |
	| -35      | PlangPlong |



@mytag
Scenario: A number has factors of 3, 5 and 7
	Given I input a number which has all three factors
	When the factor finder method is called with <input1>
	Then the result is the appropriate string <result>
	Examples:
	| input1  | result     |
	| 105      | PlingPlangPlong |
	| 210      | PlingPlangPlong |
	| -105      | PlingPlangPlong |
	| -210      | PlingPlangPlong |


@mytag
Scenario: My input number is 0
	Given I input zero
	When the factor finder method is called with <input1>
	Then the result is the appropriate string <result>
	Examples:
	| input1  | result     |
	| 0      | PlingPlangPlong |