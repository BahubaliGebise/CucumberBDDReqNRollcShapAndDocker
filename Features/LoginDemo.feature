# Features/Login.feature
Feature: Login

  Scenario: Successful login
    Given I am on the login page
    When I login with username "standard_user" and password "secret_sauce"
    Then I should see the dashboard


    
Scenario: Successful login with locked out user
    Given I am on the login page
    When I login with username "locked_out_user" and password "secret_sauce"
 