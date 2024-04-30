using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the starting price?");
            double price = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Week " + i + " of sale:\t$" + Math.Round(price, 2));
                price -= price * 0.15;
            }
        }
    }
}
