using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job89
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int currentnum = 1;
            do
            {
                Console.WriteLine("Enter a number");
                currentnum = Convert.ToInt32(Console.ReadLine());

                sum += currentnum;
            }
            while (currentnum != -1);

            sum++;
            Console.WriteLine("The total of the numbers is: " + sum);
        }
    }
}
