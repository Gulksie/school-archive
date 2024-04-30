using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your avarage");
            double avarage = Convert.ToDouble(Console.ReadLine());

            if (avarage > 100 || avarage < 0)
                Console.WriteLine("Invalid");
            else if (avarage == 100)
                Console.WriteLine("Congratulations\nExcellent");
            else if (avarage >= 70)
                Console.WriteLine("Good work");
            else if (avarage >= 50)
                Console.WriteLine("Satisfactory");
            else
                Console.WriteLine("Unsatisfactory");
        }
    }
}
