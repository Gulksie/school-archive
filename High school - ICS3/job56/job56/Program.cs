using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number?");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSecond number?");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            long sum = 0;
            for (; first <= second; first++)
            {
                Console.Write(first + " ");
                sum += first;
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
