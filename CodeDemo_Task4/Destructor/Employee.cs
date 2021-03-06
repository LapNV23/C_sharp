using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Destructor
{
    /**
     * In the above code, the destructor Employee is
     * created having the same name as that of the class and
     * the constructor.
     * The destructor is automatically called when the
     * when this will happen cannot be determined and hence
     * you have no control on when the destructor is going to be
     * executed.
     * */
    class Employee
    {
        private int _empId;
        private String _empName;
        private int _age;
        private double _salary;
        Employee(int id, String name, int age, double sal)
        {
            Console.WriteLine("Constructor for Employee called");
            _empId = id;
            _empName = name;
            _age = age;
            _salary = sal;
        }
        ~Employee()
        {
            Console.WriteLine("Destuctor for Employee called");
        }
        static void Main(string[] args)
        {
            {
                Employee emp = new Employee(1, "John", 45, 35000);
                Console.WriteLine("Employee ID: " + emp._empId);
                Console.WriteLine("Employee Name: " + emp._empName);
                Console.WriteLine("Age: " + emp._age);
                Console.WriteLine("Salary: " + emp._salary);
            }
        }
    }
}
