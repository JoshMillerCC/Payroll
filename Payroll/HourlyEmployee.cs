using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public class HourlyEmployee : Employee
    {
        public decimal hourlyPay;
        public decimal hoursWorked;
        public decimal weeklyPay;
        public decimal fica;
        public decimal fit;
        public HourlyEmployee(string firstName, string lastName, int age, int employeeID, decimal hourlyPay, decimal hoursWorked) 
            : base(firstName, lastName, age, employeeID)
        { 
            this.hourlyPay = hourlyPay; 
            this.hoursWorked = hoursWorked;
            weeklyPay = hourlyPay * hoursWorked;
            fica = Math.Round(weeklyPay * 0.0765m, 2);
            fit = Math.Round(weeklyPay * 0.265m, 2);
        }

        // calculates weekly pay
        public override string CalculatePay()
        {
            decimal pay = weeklyPay - fica - fit;
            return  pay.ToString("C2");
        }
    }
}
