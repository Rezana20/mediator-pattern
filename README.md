"# mediator-pattern" 
This project illustrates the mediator pattern. 

Scenario: 
We have two collegues(components) which need to intercommunicate. 

Classes include: 
ConcreteMediator: This allows collegues(components) to intercommunicate. The purpose of the mediator is to encapsulating the interaction
				between collegues(components). 
BaseColleague: This contains an instance of the mediator.  
ColleagueOne:  This contains two functions. Executing these functions have an affect on ColleagueTwo.
ColleagueTwo:  This contains two functions.