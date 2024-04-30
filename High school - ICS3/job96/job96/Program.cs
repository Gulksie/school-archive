using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job96
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string first = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string last = Console.ReadLine();

            Console.WriteLine(first.Substring(0, 1).ToUpper() + first.Substring(1).ToLower() + " "
                + last.Substring(0, 1).ToUpper() + last.Substring(1).ToLower());
        }
    }
}
