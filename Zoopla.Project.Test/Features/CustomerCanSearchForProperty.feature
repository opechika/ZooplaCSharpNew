Feature: For Sale Properties
  As a customer
  I want the ability to search for any properties for sale
  So that I can review the property before I buy


Scenario Outline: Customer can search for any property
  Given I navigate to zoopla homepage
  When I enter "<Location>" into the search field
  And I select "<MinPrice>" from Min price dropdown
  And I select "<MaxPrice>" from Max price dropdown
  And I select "<Property>" from Property type dropdown
  And I select "<Bedroom>" from Bedrooms dropdown
  And I click on Search button
  Then search result page is displayed with relevant results

  Examples:
  |Location|MinPrice|MaxPrice|Property|Bedroom|
  |Manchester| £140,000|£250,000|Houses|3+    |