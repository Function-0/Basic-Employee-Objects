using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec006_5_COMP123_02
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            // Create and display employee 1's profile.
            Employee employee1 = new Employee();
            string employee1Profile = String.Format($"Employee 1:\n> Employee ID: {employee1.EmployeeId:D4}\n" +
                $"> First Name: {employee1.FirstName}\n" +
                $"> Last Name: {employee1.LastName}\n" +
                $"> Base Salary: {employee1.BaseSalary:C2}\n" +
                $"> Gross Sales: {employee1.GrossSales:C2}\n" +
                $"> Comission Rate: {employee1.ComissionRate:P2}.\n");
            Console.WriteLine(employee1Profile);
            // Obtain employee 2's information from user.
            Console.Write("Enter employee 2's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter employee 2's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter employee 2's base salary: ");
            string userInput = Console.ReadLine();
            double baseSalary;
            double.TryParse(userInput, out baseSalary);
            double grossSales;
            bool isInvalidGrossSales = true;
            // Check if employee 2's gross sales value is valid.
            do
            {
                Console.Write("Enter employee 2's gross sales: ");
                userInput = Console.ReadLine();
                double.TryParse(userInput, out grossSales);
                isInvalidGrossSales = grossSales <= 0;
                if (isInvalidGrossSales)
                {
                    Console.WriteLine("Error: Employee 2's gross sale value required to be greater than 0.");
                }
            } while (isInvalidGrossSales);
            double comissionRate;
            bool isInvalidComissionRate = true;
            // Check if employee 2's comission rate value is valid.
            do
            {
                Console.Write("Enter employee 2's comission rate: ");
                userInput = Console.ReadLine();
                double.TryParse(userInput, out comissionRate);
                isInvalidComissionRate = (comissionRate < 0.1) || (comissionRate > 1.0);
                if (isInvalidComissionRate)
                {
                    Console.WriteLine("Error: Employee 2's comission rate required to be between 0.1% and 1.0% inclusive.");
                }
            } while (isInvalidComissionRate);
            int employeeId = 0001; // 4-digit number.
            // Create and display employee 2's profile and their comission earnings.
            Employee employee2 = new Employee(employeeId, firstName, baseSalary);
            employee2.LastName = lastName;
            employee2.GrossSales = grossSales;
            employee2.ComissionRate = comissionRate;
            string employee2Profile = String.Format($"\nEmployee 2:\n> Employee ID: {employee2.EmployeeId:D4}\n" +
                $"> First Name: {employee2.FirstName}\n" +
                $"> Last Name: {employee2.LastName}\n" +
                $"> Base Salary: {employee2.BaseSalary:C2}\n" +
                $"> Gross Sales: {employee2.GrossSales:C2}\n" +
                $"> Comission Rate: {employee2.ComissionRate:P2}.");
            Console.WriteLine(employee2Profile + "\n-----");
            Console.WriteLine($"> {employee2.FirstName}'s Earnings: {employee2.Earnings():C2}");
            // Prevent immediate exit.
            Console.ReadKey();
        }
    }
}
