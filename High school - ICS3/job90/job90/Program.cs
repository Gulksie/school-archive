using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job90
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost;
            while (true)
            {
                Console.WriteLine("What is the starting price of the item?");

                try
                {
                    cost = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not valid\n");
                }
            }
            Console.WriteLine();

            int i = 1;
            for (; cost >= 10; i++)
            {
                Console.WriteLine("Week " + i + ":\t" + Math.Round(cost, 2));
                cost -= cost * 0.2;
            }

            Console.WriteLine("Week " + i + ":\t" + Math.Round(cost, 2));
        }
    }
}
