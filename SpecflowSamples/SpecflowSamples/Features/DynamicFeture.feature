Feature: DynamicTableFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@DynamicTable
Scenario: DynamicTable Convert data into table
	Given I have entered 50 into the calculator event
	Then I should see the passed data into the dynamic table
	|Menu_1			|Menu_2	|Menu_3		|Menu_4|
	|Application	|KFI	|Settings	|Logout|
