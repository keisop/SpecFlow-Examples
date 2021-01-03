Feature: Feature Title 2

Background:
	Given the following books
		|Author			|Title								|Price	|
		|Martin Fowler	|Analysis Patterns					|50.20	|
		|Eric Evans		|Domain Driven Design				|46.34	|
		|Ted Pattison	|Inside Windows SharePoint Services	|31.49	|
		|Gojko Adzic	|Bridging the Communication Gap		|24.75	|


Scenario: Scenario Title
	Given I have a shopping cart with: 'Analysis Patterns'
	When I place 'Domain Driven Design' into the shopping cart
	Then my shopping cart should contain 2 types of items
	And my shopping cart should contain 1 copy of 'Analysis Patterns'
	And my shopping cart should contain 1 copy of 'Domain Driven Design'

