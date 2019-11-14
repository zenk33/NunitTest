using System;
using TechTalk.SpecFlow;
using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NunitTest
{
    [Binding]
    public class CreditCheckSteps
    {
        Customer customer = new Customer();
        private string result;
        

        [Given(@"an individual customer with an annual salary of (.*)")]
        public void GivenAnIndividualCustomerWithAnAnnualSalaryOf(decimal salary)
        {
            customer.Salary = salary;
        }
        
        [When(@"the customer applies for a credit card")]
        public void WhenTheCustomerAppliesForACreditCard()
        {
            result = customer.CheckSalary();
        }
        
        [Then(@"the credit card application should be (.*)")]
        public void ThenTheCreditCardApplicationShouldBe(string expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
        
        [Then(@"if approved, the maximum credit limit should be (.*)")]
        public void ThenIfApprovedTheMaximumCreditLimitShouldBe(decimal expectedResult)
        {
            decimal result = customer.CalculateMaxLimit();
            Assert.AreEqual(result, expectedResult);
        }
    }
}
