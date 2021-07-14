using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab1
{
    class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        //Public properties
        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }

            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        // Constructor
        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            
        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        // This method returns the employee's name
        public String getName()
        {
            return this.Name;
        }

        //Create integer variable called "employeeCount" and assigns value to 1
        private static int employeeCount = 1; 
    }
}
