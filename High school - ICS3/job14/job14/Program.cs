using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The first real number is ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("The second real number is ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total of these numbers is " + (num1 + num2));
        }
    }
}
