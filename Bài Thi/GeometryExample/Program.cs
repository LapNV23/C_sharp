using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GeometryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }
        static void Process()
        {
            {
                Console.WriteLine("Enter the dimenstions of the cylinder: ");
                Console.WriteLine("Radius: ");
                double Radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Height: ");
                double Height = double.Parse(Console.ReadLine());

                double BaseArea = Radius * Radius * Math.PI;
                double LateralArea = 2 * Math.PI * Radius * Height;
                double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
                double Volume = Math.PI * Radius * Radius * Height;
                Console.WriteLine("Cylinder characteristics");
                Console.WriteLine("Radius: {0} : Height: {1}", Radius, Height);
                Console.WriteLine("Base: {0} : Lateral: {1} : Total: {2} : Volume: {3}", BaseArea, LateralArea, TotalArea, Volume);
                Console.ReadLine();
            }
        }
    }
}
