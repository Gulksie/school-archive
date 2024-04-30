using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job120
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            while (true)
            {
                Console.WriteLine("How many numbers should be in the array?");

                try
                {
                    arr = new int[Convert.ToInt32(Console.ReadLine())];
                    Console.WriteLine();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input.\n");
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number");

                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The array:");
            long sum = 0;
            foreach (int i in arr)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
