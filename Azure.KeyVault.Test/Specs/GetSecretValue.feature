Feature: GetSecretValue_By_SecretName

Scenario: Get Secret from KeyVault using Secret Name
	Given I want to get the latest version of the TestSecret01 secret
	When I call the API with Secret Name
	Then I should return the TestSecret01 Value

Scenario: Get Secret from KeyVault using Secret Name and Secret Version
	Given I want to get a specfic version of the TestSecret02 secret
	When I call the API with Secret Name and Version
	Then I should return the TestSecret02 Value