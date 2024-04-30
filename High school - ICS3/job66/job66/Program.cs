using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job66
{
    class Program
    {
        static void Main(string[] args)
        {
            //execute job66
            while (true)
            {
                Console.WriteLine("What grade are you in?");
                string input = Console.ReadLine();

                if (input == "9")
                    Console.WriteLine("You are still adjusting to high school");
                else if (input == "10")
                    Console.WriteLine("Start thinking about your courses");
                else if (input == "11")
                    Console.WriteLine("Start thinking about post secondary");
                else if (input == "12")
                    Console.WriteLine("Last year, make it a good one!");
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                break;
            }
        }
    }
}
