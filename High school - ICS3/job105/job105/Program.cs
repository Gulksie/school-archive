using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            string length = "";
            for (int i = 1; i <= input.Length; i++)
            {
                length += i.ToString();
            }

            Console.WriteLine(input + "\t" + length);
            for (int i = 0; i < input.Length; i++)
            {
                input = input.Substring(1) + input.ElementAt(0);
                length = length.Substring(1) + length.ElementAt(0);
                Console.WriteLine(input + "\t" + length);
            }
        }
    }
}
