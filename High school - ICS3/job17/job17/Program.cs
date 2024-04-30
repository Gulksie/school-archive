using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job17
{
    class Program
    {
        static void Main(string[] args)
        {
            double sales;
            while (true)
            {
                Console.WriteLine("Enter sales");
                string input = Console.ReadLine();

                try
                {
                    sales = Convert.ToDouble(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number!\n");
                }
            }

            double commision = 0.14 * sales;
            Console.WriteLine("Comission: " + Math.Round(commision, 2).ToString());
        }
    }
}
