using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear()
            Console.WriteLine("What avarage");
            int avarage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (avarage > 79 && avarage < 101)
                Console.WriteLine("Excellent");
            else if (avarage > 69 && avarage < 80)
                Console.WriteLine("Good");
            else if (avarage > 49 && avarage < 70)
                Console.WriteLine("You need to work harder");
            else if (avarage > -1 && avarage < 50)
                Console.WriteLine("You may fail the course");
            else
                Console.WriteLine("Invalid input");
        }
    }
}
