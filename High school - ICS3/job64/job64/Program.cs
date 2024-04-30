using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job64
{
    class Program
    {
        static void Main(string[] args)
        {
            byte r = 0;
            byte y = 0;
            byte b = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("What is your favorite colour? (Red, yellow, blue)");
                string input = Console.ReadLine().ToLower();

                if (input == "red" || input == "r")
                    r++;
                else if (input == "yellow" || input == "y")
                    y++;
                else if (input == "blue" || input == "b")
                    b++;
                else
                {
                    Console.WriteLine("Not valid.\n");
                    i--;
                }
            }

            Console.WriteLine("Red " + r);
            Console.WriteLine("Blue " + b);
            Console.WriteLine("Yellow " + y);
        }
    }
}
