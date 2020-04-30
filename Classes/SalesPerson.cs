﻿using System;
using System.Collections.Generic;
using System.Text;
using Classes;

namespace Classes
{
    public class SalesPerson : Employee
    {

        private double SuccessSaleRevenue { get; set; }

        public SalesPerson()
        {

        }

        public SalesPerson(string first, string last)
        {
            FirstName = first;
            LastName = last;
            Salary = 500;
            Role = Role.Sales;
        }

        public void ExtendSuccessSaleRevenue(double successValue)
        {
            SuccessSaleRevenue += successValue;
        }
        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                return Salary + 800;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return Salary + 2000;
            }
            else
            {
                return Salary;
            }
        }

    }
}
