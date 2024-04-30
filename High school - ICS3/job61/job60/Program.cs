using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job60
{
    class Program
    {
        static void Main(string[] args)
        {
            short total = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("What is mark " + i + "?");
                total += Convert.ToInt16(Console.ReadLine());
            }

            total /= 4;

            if (total >= 80)
                Console.WriteLine("Excellent");
            else if (total > 50)
                Console.WriteLine("Satisfactory");
            else
                Console.WriteLine("Unsatisfactory");

            Console.WriteLine("Your average is " + total + "%.");
        }
    }
}
