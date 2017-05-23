Feature: ArgumentConvesionFeature
	Simple feature to convert interger argument to date after specified value

@mytag
Scenario: Force password update if current password is too old
  Given I last changed my password 30 days ago
  When I log in successfully
  Then I should be asked to enter a new password
