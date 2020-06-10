using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public abstract class Employee
    {
        // 5 cyclomatic complexities:
        // 1 for Employee constructor,
        // 1 for Name : string,
        // 1 for Age : int,
        // 1 for Employee : int,
        // 1 for CalculatePay() : string

        protected string firstName;
        protected string lastName;
        protected int age;
        protected int employeeID;

        protected Employee(string firstName, string lastName, int age, int employeeID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.employeeID = employeeID;
        }

        public string Name { get { return lastName + ", " + firstName; } }
        public int Age { get { return age; } }
        public int EmployeeID { get { return employeeID; } }

        // calculates weekly pay
        public abstract string CalculatePay();
    }
}
