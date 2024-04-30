using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme dat integer");
            int integer = Convert.ToInt32(Console.ReadLine());

            bool two = (integer % 2) == 0;
            bool three = (integer % 3) == 0;
            bool four = (integer % 4) == 0;
            bool five = (integer % 5) == 0;

            Console.Clear();
            Console.WriteLine("Divisable by 2:\t" + two);
            Console.WriteLine("Divisable by 3:\t" + three);
            Console.WriteLine("Divisable by 4:\t" + four);
            Console.WriteLine("Divisable by 5:\t" + five);
        }
    }
}
