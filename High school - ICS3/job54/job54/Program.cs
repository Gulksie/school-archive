using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Press any key to start");
            Console.ReadKey(true);
            Console.Clear();

            int num;
            while (true)
            {
                Console.WriteLine("Enter a number greater than one");

                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num <= 1)
                        Console.WriteLine("Number not greater than 1\n");
                    else
                        break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number!\n");
                }
            }

            int total = 0;
            for (int i = 0; i <= num; i++)
            {
                total += i;
            }

            Console.WriteLine("The sum of numbers from 1 to " + num + " is " + total + ".");
        }
    }
}
