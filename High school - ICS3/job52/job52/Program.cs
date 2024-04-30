using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job52
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter mark " + (i+1));

                int mark = Convert.ToInt32(Console.ReadLine());
                total += mark;
            }

            double avarage = total / 4.0;
            Console.WriteLine("Your avarage is " + Math.Round(avarage, 2) + "%.");
        }
    }
}
