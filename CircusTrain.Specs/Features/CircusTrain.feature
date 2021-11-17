Feature: CircusTrain
	Program that fills up wagons with animals

@mytag
Scenario Outline: Filling up the train
	Given there are <carnivores> carnivores
	And <herbivores> herbivores
	When the supervisor gets to the farm
	Then the train gets filled up
	Then the train goes on it's way without problems
	
Examples: 
	| carnivores | herbivores |
	| 5         | 15        |
	| 20        | 2         |
	| 3         | 6         |

Scenario Outline: Filling up more trains
	Given there are a total of <animals> animals
	When the supervisor gets to the farm
	Then the train gets filled up
	Then the train goes on it's way without problems
	
Examples: 
	| animals |
	| 5       |
	| 100     |
	| 150     |
	| 200     |