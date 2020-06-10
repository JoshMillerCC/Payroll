using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    class Convert_ToDecimal
    {
        public static decimal ConvertToDecimal(string value)
        {
            decimal number;
            while (!decimal.TryParse(value, out number))
            {
                Console.WriteLine("Enter a valid age.");
                value = Console.ReadLine();
            }
            return number;
        }
    }
}
