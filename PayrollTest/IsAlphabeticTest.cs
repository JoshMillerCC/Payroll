using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;
using System.Collections.Generic;

namespace PayrollTest
{
    [TestClass]
    public class IsAlphabeticTest
    {
        // 3 cyclomatic complexities:
        // 1 if they don't enter any value,
        // 1 if they do enter a value of all chars,
        // 1 if they enter a value with something other than chars
        [TestMethod]
        public void IsAllAlphabetic_AllCharString_ReturnsTrue()
        {
            string value = "qwer";
            var result = IsAlphabetic.IsAllAlphabetic(value);
            Assert.IsTrue(result);
            
        }

        [TestMethod]
        public void IsAllAlphabetic_NotAllCharString_ReturnsFalse()
        {
            string value = "qwer1";
            var result = IsAlphabetic.IsAllAlphabetic(value);
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void IsAllAlphabetic_EmptyString_ReturnsFalse()
        {
            string value = "";
            var result = IsAlphabetic.IsAllAlphabetic(value);
            Assert.IsFalse(result);

        }
    }
}
