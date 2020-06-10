using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace PayrollTest
{
    [TestClass]
    public class mainProgramTest
    {
        [TestMethod]
        public void menuChoice_returnsString_returnsTrue()
        {
            bool result;
            var isString = Payroll.Program.menuChoices();
            if(isString is string) { result = true; }
            else { result = false; }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void printInfo_returnsString_returnsTrue()
        {
            bool result;
            List<Employee> le = new List<Employee>();
            var he = new HourlyEmployee("Josh", "Miller", 29, 13, 20m, 20m);
            var se = new SalariedEmployee("Sarah", "Hoium", 24, 4, 2000m);
            le.Add(he);
            le.Add(se);
            var isString = Payroll.Program.printInfo(le);
            if(isString is string) { result = true; }
            else { result = false; }
            Assert.IsTrue(result);
        }
    }
}
