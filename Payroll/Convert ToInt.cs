using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    class Convert_ToInt
    {
        public static int ConvertToInt(string value)
        {
            int number;
            while (!int.TryParse(value, out number))
            {
                Console.WriteLine("Enter a valid age.");
                value = Console.ReadLine();
            }
            return number;
        }
    }
}
