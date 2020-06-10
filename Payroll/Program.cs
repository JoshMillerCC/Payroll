using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public class Program
    {
        public static HourlyEmployee createHourly()
        {
            string fName, lName, age, ID, hPay, hWorked;
            int ageNumber, IDNumber;
            decimal hPayNumber, hWorkedNumber;
            // add a hourly employee
            Console.WriteLine("Employee first name?");
            fName = Console.ReadLine();

            while (!IsAlphabetic.IsAllAlphabetic(fName))
            {
                Console.WriteLine("Enter a valid first name.");
                fName = Console.ReadLine();
            }

            Console.WriteLine("Employee last name?");
            lName = Console.ReadLine();

            while (!IsAlphabetic.IsAllAlphabetic(lName))
            {
                Console.WriteLine("Enter a valid last name.");
                lName = Console.ReadLine();
            }

            Console.WriteLine("Employee age?");
            age = Console.ReadLine();
            ageNumber = Convert_ToInt.ConvertToInt(age);

            Console.WriteLine("Employee ID number?");
            ID = Console.ReadLine();
            IDNumber = Convert_ToInt.ConvertToInt(ID);

            Console.WriteLine("Employee hourly pay?");
            hPay = Console.ReadLine();
            hPayNumber = Convert_ToDecimal.ConvertToDecimal(hPay);

            Console.WriteLine("Employee hours worked?");
            hWorked = Console.ReadLine();
            hWorkedNumber = Convert_ToDecimal.ConvertToDecimal(hWorked);

            Console.WriteLine("");

            HourlyEmployee he = new HourlyEmployee(fName, lName, ageNumber, IDNumber, hPayNumber, hWorkedNumber);
            return he;
        }
        public static SalariedEmployee createSalaried()
        {
            string fName, lName, age, ID, mPay;
            int ageNumber, IDNumber;
            decimal mPayNumber;

            // add a salaried employee

            Console.WriteLine("Employee first name?");
            fName = Console.ReadLine();

            while (!IsAlphabetic.IsAllAlphabetic(fName))
            {
                Console.WriteLine("Enter a valid first name.");
                fName = Console.ReadLine();
            }

            Console.WriteLine("Employee last name?");
            lName = Console.ReadLine();

            while (!IsAlphabetic.IsAllAlphabetic(lName))
            {
                Console.WriteLine("Enter a valid last name.");
                lName = Console.ReadLine();
            }

            Console.WriteLine("Employee age?");
            age = Console.ReadLine();
            ageNumber = Convert_ToInt.ConvertToInt(age);

            Console.WriteLine("Employee ID number?");
            ID = Console.ReadLine();
            IDNumber = Convert_ToInt.ConvertToInt(ID);

            Console.WriteLine("Employee monthly pay?");
            mPay = Console.ReadLine();
            mPayNumber = Convert_ToDecimal.ConvertToDecimal(mPay);

            Console.WriteLine("");

            SalariedEmployee se = new SalariedEmployee(fName, lName, ageNumber, IDNumber, mPayNumber);
            return se;
        }

        public static string menuChoices()
        {
            string one = "1. Add salaried employee\n";
            string two = "2. Add hourly employee\n";
            string three = "3. Run report\n";
            string four = "4. Quit\n";
            StringBuilder sb = new StringBuilder(one);
            sb.Append(two);
            sb.Append(three);
            sb.Append(four);

            return sb.ToString();
        }

        public static string printInfo(List<Employee> le)
        {
            StringBuilder sb = new StringBuilder();
            decimal ficaHP = 0m, fitHP = 0m, grossHP = 0m, netHP = 0m, ficaSP = 0m,
                                fitSP = 0m, grossSP = 0m, netSP = 0m;

            foreach (Employee p in le)
            {
                sb.Append("Employee Weekly Breakdown:\n");
                sb.Append("Employee name: " + p.Name + "\n");
                sb.Append("Employee age: " + p.Age + "\n");
                sb.Append("Employee ID: " + p.EmployeeID + "\n");

                if (p is HourlyEmployee)
                {
                    HourlyEmployee hp = p as HourlyEmployee;

                    sb.Append("Employee hourly pay: " + hp.hourlyPay.ToString("C2") + "\n");
                    sb.Append("Employee hours worked: " + hp.hoursWorked.ToString() + "\n");
                    sb.Append("Employee FICA paid: " + hp.fica.ToString("C2") + "\n");
                    sb.Append("Employee Federal Tax Withheld: " + hp.fit.ToString("C2") + "\n");
                    sb.Append("Employee weekly take home: " + hp.CalculatePay() + "\n");
                    sb.Append("" + "\n");

                    ficaHP += Math.Round(hp.fica, 2);
                    fitHP += Math.Round(hp.fit, 2);
                    grossHP += hp.weeklyPay;
                }
                netHP = grossHP - ficaHP - fitHP;

                if (p is SalariedEmployee)
                {
                    SalariedEmployee sp = p as SalariedEmployee;

                    sb.Append("Employee monthly pay: " + sp.monthlyPay.ToString("C2") + "\n");
                    sb.Append("Employee FICA paid: " + sp.fica.ToString("C2") + "\n");
                    sb.Append("Employee Federal Tax Withheld: " + sp.fit.ToString("C2") + "\n");
                    sb.Append("Employee weekly take home: " + sp.CalculatePay() + "\n");
                    sb.Append("" + "\n");

                    ficaSP += Math.Round(sp.fica, 2);
                    fitSP += Math.Round(sp.fit, 2);
                    grossSP = grossSP + sp.weeklyPay;

                }
                netSP = grossSP - ficaSP - fitSP;
            }

            sb.Append("Hourly Employee Weekly Data:" + "\n");
            sb.Append("Gross Pay: " + grossHP.ToString("C2") + "\n");
            sb.Append("Net Pay: " + netHP.ToString("C2") + "\n");
            sb.Append("FICA paid: " + ficaHP.ToString("C2") + "\n");
            sb.Append("Federal Tax Withheld: " + fitHP.ToString("C2") + "\n");
            sb.Append("" + "\n");

            sb.Append("Salaried Employee Weekly Data:" + "\n");
            sb.Append("Gross Pay: " + grossSP.ToString("C2") + "\n");
            sb.Append("Net Pay: " + netSP.ToString("C2") + "\n");
            sb.Append("FICA paid: " + ficaSP.ToString("C2") + "\n");
            sb.Append("Federal Tax Withheld: " + fitSP.ToString("C2") + "\n");
            sb.Append("" + "\n");

            sb.Append("Company Wide Weekly Data:" + "\n");
            sb.Append("Gross Pay: " + (grossHP + grossSP).ToString("C2") + "\n");
            sb.Append("Net Pay: " + (netHP + netSP).ToString("C2") + "\n");
            sb.Append("FICA paid: " + (ficaHP + ficaSP).ToString("C2") + "\n");
            sb.Append("Federal Tax Withheld: " + (fitHP + fitSP).ToString("C2") + "\n");
            sb.Append("" + "\n");

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();

            string menu = "l";

            while (menu != "4")
            {
                string choices = menuChoices();
                Console.WriteLine(choices);

                menu = Console.ReadLine();
                Console.WriteLine("");

                switch (menu)
                {
                    case "1":
                        // add salaried employee
                        Employee se = createSalaried();
                        emp.Add(se);
                        break;

                    case "2":
                        // add hourly employee
                        Employee he = createHourly();
                        emp.Add(he);
                        break;

                    case "3":
                        // run report
                        Console.WriteLine(printInfo(emp));
                        break;

                    case "4":
                        // exit out of the while loop
                        break;

                    default:
                        // have the user pick a new option since they pressed something that wasn't an option
                        Console.WriteLine("Pick a valid choice");
                        Console.WriteLine("");
                        break;

                }
            }
        }
    }
}
