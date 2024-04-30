using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job119
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                arr[i] = rnd.Next(1, 101);
            }

            int sum = 0;
            foreach (int i in arr)
            {
                Console.WriteLine(i);
                sum += i;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
