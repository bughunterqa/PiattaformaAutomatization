Feature: Login

@mytag
Scenario: Admin logging 
	Given I enter email 
	And I enter password 'YaWMJWgh5emWQt4'
	When I click login
	Then Admin is logged 'Creators - Author Searching'