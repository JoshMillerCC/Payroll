using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;

namespace PayrollTest
{
    [TestClass]
    public class EmployeeTest
    {
        // 5 cyclomatic complexities: 
        // 1 for Employee constructor,
        // 1 for Name : string,
        // 1 for Age : int,
        // 1 for Employee : int,
        // 1 for CalculatePay() : string
        [TestMethod]
        public void EmployeeConstructor_CreateEmployee_ReturnsTrue()
        {
            string fname = "Josh";
            string lname = "Miller";
            int age = 29;
            int id = 13;
            decimal pay = 4000m;
            var emp = new SalariedEmployee(fname, lname, age, id, pay);
            bool result;
            if (emp is Employee)
                result = true;
            else
                result = false;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmployeeName_ReturnsString_ReturnsTrue()
        {
            string fname = "Josh";
            string lname = "Miller";
            int age = 29;
            int id = 13;
            decimal pay = 4000m;
            var emp = new SalariedEmployee(fname, lname, age, id, pay);
            bool result;
            if (emp.Name is string)
                result = true;
            else
                result = false;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmployeeAge_ReturnsInt_ReturnsTrue()
        {
            string fname = "Josh";
            string lname = "Miller";
            int age = 29;
            int id = 13;
            decimal pay = 4000m;
            var emp = new SalariedEmployee(fname, lname, age, id, pay);
            bool result;
            if (emp.Age is int)
                result = true;
            else
                result = false;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmployeeID_ReturnsInt_ReturnsTrue()
        {
            string fname = "Josh";
            string lname = "Miller";
            int age = 29;
            int id = 13;
            decimal pay = 4000m;
            var emp = new SalariedEmployee(fname, lname, age, id, pay);
            bool result;
            if (emp.EmployeeID is int)
                result = true;
            else
                result = false;
            Assert.IsTrue(result);
        }
    }
}
