using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job57
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            //version 1
            /*for (int i = 15; i > 0; i--)
            {
                Console.Write("+ " + i + " ");
                total += i;
            }
            Console.WriteLine("= " + total);*/

            //version 2
            Console.Write("15 ");
            total = 15;
            for (int i = 14; i > 0; i--)
            {
                Console.Write("+ " + i + " ");
                total += i;
            }

            Console.WriteLine("= " + total);
        }
    }
}
