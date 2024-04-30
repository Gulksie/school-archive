using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job91
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string input = "";
            for (; input != "ottawa"; i++)
            {
                Console.WriteLine("What is the capital of Canada?");
                input = Console.ReadLine().ToLower();
                Console.WriteLine();
            }

            Console.WriteLine("CORRECT");
            Console.WriteLine(i + " guesses taken");
        }
    }
}
