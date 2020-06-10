using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public class IsAlphabetic
    {
        // 3 cyclomatic complexities:
        // 1 if they don't enter any value,
        // 1 if they do enter a value of all chars,
        // 1 if they enter a value with something other than chars
        public static bool IsAllAlphabetic(string value)
        {
            if(value == "" || value == null)
            {
                return false;
            }
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }
    }
}
