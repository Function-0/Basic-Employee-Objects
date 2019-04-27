using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec006_5_COMP123_02
{
    class Employee
    {
        private int employeeId; // 4-digit number.

        public int EmployeeId
        {
            get { return employeeId; }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BaseSalary { get; set; }
        public double GrossSales { get; set; }
        public double ComissionRate { get; set; }

        public Employee()
        {
            this.employeeId = 0000; // 4-digit number.
            this.FirstName = "";
            this.LastName = "";
            this.BaseSalary = 1000;
            this.GrossSales = 0;
            this.ComissionRate = 0.1;
        }
        
        public Employee(int employeeID, string firstName, double baseSalary)
        {
            this.employeeId = employeeID;
            this.FirstName = firstName;
            this.BaseSalary = baseSalary;
        }

        public double Earnings()
        {
            double comissionEarnings = (this.ComissionRate * this.GrossSales) + this.BaseSalary;
            return comissionEarnings;
        }
    }
}
