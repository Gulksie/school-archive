using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job75
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double current = 1;
            while (true)
            {
                sum += current;

                Console.WriteLine();
                Console.WriteLine("Number = " + current);
                Console.WriteLine("Sum = " + sum);

                current /= 2;

                Console.ReadKey(true);
            }
        }
    }
}
