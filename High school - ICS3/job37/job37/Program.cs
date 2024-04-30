using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which period lunch?");
            string period = Console.ReadLine();

            Console.WriteLine();
            if (period == "2" || period.ToLower() == "two")
                Console.WriteLine("I just had my breakfast!");
            else if (period == "3" || period.ToLower() == "three")
                Console.WriteLine("I'm ready to eat");
            else if (period == "4" || period.ToLower() == "four")
                Console.WriteLine("I'm starving");
            else
                Console.WriteLine("Invalid input");
        }
    }
}
