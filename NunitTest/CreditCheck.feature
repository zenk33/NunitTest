Feature: CreditCheck
	Credit card financial checks
	In order to avoid bad debts
	As a financial institution
	I want to ensure that a customer's credit limit is in line with their incomes

@mytag
Scenario: The max credit card limit depends on the customer's salary

	Given an individual customer with an annual salary of 15000.00
	When the customer applies for a credit card
	Then the credit card application should be Approved
	And if approved, the maximum credit limit should be 3750.00

