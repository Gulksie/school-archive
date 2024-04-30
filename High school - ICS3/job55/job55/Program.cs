using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job55
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;
            for (int i = 0; i <= 100; i += 3)
            {
                Console.WriteLine(i);
                nums++;
            }
            Console.WriteLine("\nThe number of multiples of three in 100 is " + nums);
        }
    }
}
