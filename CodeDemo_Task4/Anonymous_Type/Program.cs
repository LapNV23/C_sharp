using System;
using System.Text;
using System.Reflection;

namespace Anonymous_Type
{
    class Program
    {
        static void Main1(string[] args)
        {
            // Anonymous Type with three properties.
            var stock = new { Name = "Michgan Enterprises", Code = 1301, Price = 35056.75 };
            Console.WriteLine("Stock Name: " + stock.Name);
            Console.WriteLine("Stock Code: " + stock.Code);
            Console.WriteLine("Stock Price: " + stock.Price);
            Console.Read();
        }
        
        public static void Main (string[] args)
        {
            Employee david = new Employee();
            // Creating the anonymous type instance and
            // passing it to a method.
            david.DisplayDetails(new { FirstName = "David", LastName = "Blake", Age = 30 });
            Console.Read();
        }
    }
}
