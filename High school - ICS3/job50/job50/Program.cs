using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int total = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number");
                int input = Convert.ToInt32(Console.ReadLine());

                total += input;
                Console.WriteLine();
            }

            Console.WriteLine("The total is " + total);
        }
    }
}
