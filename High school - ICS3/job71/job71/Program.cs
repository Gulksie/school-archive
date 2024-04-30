using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job71
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 1;;i++)
            {
                Console.WriteLine("How much did item " + i + " cost?");
                string input = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    if (input == "0")
                        break;

                    sum += Convert.ToDouble(input);
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number.\n");
                    i--;
                }
            }

            Console.WriteLine("You will have to pay $" + Math.Round(sum, 2));
        }
    }
}
