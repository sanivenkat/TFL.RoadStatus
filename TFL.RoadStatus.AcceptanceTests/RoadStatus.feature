Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Valid Road DisplayName
	Given a valid road ID 'A2' is specified
	When the client is run
	Then the road displayName should be displayed as 'A2'

Scenario: Valid Road Status
	Given a valid road ID 'A2' is specified
	When the client is run
	Then the road statusSeverity should be displayed as 'Good'

Scenario: Valid Road Severity Description
	Given a valid road ID 'A2' is specified
	When the client is run
	Then the road statusSeverityDescription should be displayed as 'No Exceptional Delays'

Scenario: Informative Error
	Given an invalid road ID 'A345' is specified
	When the client is run
	Then the application should return an informative error AS 'The following road id is not recognised: A345'

