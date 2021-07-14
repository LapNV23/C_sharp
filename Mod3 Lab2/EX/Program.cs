using System;

namespace EX
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnMultiOut(out first, out sValue);
            Console.WriteLine($"{first.ToString}, {sValue}");
            static void ReturnMultiOut (out int i, out string s)
            {
                i = 25;
                s = "using out";
            }
        }
    }
}
