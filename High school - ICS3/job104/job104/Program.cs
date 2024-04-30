using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job104
{
    class Program
    {
        static void Main(string[] args)
        {
            string first;
            int last;

            while (true)
            {
                Console.WriteLine("Enter a 5 digit product code");

                string input = Console.ReadLine();

                try
                {
                    Convert.ToInt32(input); //make sure it's all a number
                    first = input.Substring(0, 4);
                    last = Convert.ToInt32(input.Substring(4));
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }
            }

            int previous = Convert.ToInt32(first.Substring(0, 1));
            int total = previous;
            total++;
            total *= previous;

            foreach(char i in first.Substring(1))
            {
                int j = Convert.ToInt32(i);
                total += j * previous;
                previous = j;
            }

            total %= 11;

            if (total == last)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
