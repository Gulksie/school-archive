using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job62
{
    class Program
    {
        static void Main(string[] args)
        {
            int _50 = 0;
            int _100 = 0;
            int _150 = 0;
            int _200 = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number");
                short num = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();

                if (num < 1 || num > 200)
                {
                    Console.WriteLine("Bad boy\n");
                    i--;
                    continue;
                }

                else if (num < 51)
                    _50++;
                else if (num < 101)
                    _100++;
                else if (num < 151)
                    _150++;
                else
                    _200++;
            }

            Console.WriteLine(_50 + " numbers between 1 and 50");
            Console.WriteLine(_100 + " numbers between 51 and 100");
            Console.WriteLine(_150 + " numbers between 101 and 150");
            Console.WriteLine(_200 + " numbers between 151 and 200");
        }
    }
}
