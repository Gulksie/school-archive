using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme a number");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Number: " + num);
            Console.WriteLine("Square: " + num*num);
            Console.WriteLine("Cube: " + Math.Pow(num, 3));
            Console.WriteLine("Square Root: " + Math.Sqrt(num));
        }
    }
}
