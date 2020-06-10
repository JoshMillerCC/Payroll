using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public class SalariedEmployee : Employee
    {
        public decimal monthlyPay;
        public decimal weeklyPay;
        public decimal fica;
        public decimal fit;
        public decimal pay;
        public SalariedEmployee(string firstName, string lastName, int age, int employeeID, decimal monthlyPay) 
            : base(firstName, lastName, age, employeeID)
        { 
            this.monthlyPay = monthlyPay;
            weeklyPay = (monthlyPay * 12) / 52;
            fica = Math.Round(weeklyPay * 0.0765m, 2);
            fit = Math.Round(weeklyPay * 0.265m, 2);
        }

        // calculates weekly pay
        public override string CalculatePay()
        {
            pay = weeklyPay - fica - fit;
            return pay.ToString("C2");
        }
    }
}
