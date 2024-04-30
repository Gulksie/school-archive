using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job83
{
    class Program
    {
        static void Main(string[] args)
        {
            int lunch;

            for (int i = 1; i <= 5; i++)
            {
                //Ask user for lunch period
                Console.WriteLine("What period is your lunch?");
                lunch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                while (lunch < 2 || lunch > 4)
                {
                    Console.WriteLine("What is your lunch period?");
                    lunch = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Thank you!");
        }
    }
}
