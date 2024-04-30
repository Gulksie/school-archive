using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word.");
            string input = Console.ReadLine();

            if (input.ElementAt(0) == input.ElementAt(input.Length -1))
                Console.WriteLine("The first letter and the last letter are the same.");
            else
                Console.WriteLine("The first letter and the last letter are different.");
        }
    }
}
