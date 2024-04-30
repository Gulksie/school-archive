using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job51
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i <= 10; i++)
            {
                total += i;
            }

            Console.WriteLine("The total is " + total);
        }
    }
}
