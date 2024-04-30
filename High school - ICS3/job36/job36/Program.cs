using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sales?");
            double sales = Convert.ToDouble(Console.ReadLine());

            double commision = 0.14 * sales;

            Console.WriteLine("Commision: " + Math.Round(commision, 2));
        }
    }
}
