using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class Customer
    {
        public decimal Salary { get; set; }
        public decimal MaxLimit { get; set; }

        public string Approval { get; set; }


        public string CheckSalary() {

            if (Salary >= 10000)
            {
                Approval = "Approved";
            }
            else 
            {
                Approval = "Refused";
            }
            return Approval;
        }

        public decimal CalculateMaxLimit() {

            if (Approval != "Refused")
            {
                if (Salary != 0)
                {
                    MaxLimit = (Salary * 25 / 100);
                }
            }
            else 
            {
                MaxLimit = 0;
            }
            return MaxLimit;
        }



        


    }
}
