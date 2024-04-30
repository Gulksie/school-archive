using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job76
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 1; ; i++)
            {
                int other;
                if (i % 2 == 0)
                    other = -1;
                else
                    other = 1;

                sum += other / (double)i;
                Console.WriteLine(sum);
                Console.ReadKey(true);
                Console.WriteLine();
            }
        }
    }
}
