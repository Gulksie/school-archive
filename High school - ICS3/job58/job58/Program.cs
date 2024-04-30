using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job58
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            byte count = 0;
            int total = 0;
            for (int i = 2; count < 10; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                    total += i;
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine(total);
        }
    }
}
