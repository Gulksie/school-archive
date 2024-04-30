using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job73
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count;
            for (count = 0; sum < 50; count ++)
            {
                Console.WriteLine("Input a number");
                sum += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Numbers entered " + count);
            Console.WriteLine("Total: " + sum);
        }
    }
}
