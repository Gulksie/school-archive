using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a course code");
            string input = Console.ReadLine().ToLower();

            switch (input.ElementAt(5))
            {
                case 'c':
                    Console.WriteLine("College");
                    break;
                case 'm':
                    Console.WriteLine("Mixed");
                    break;
                case 'u':
                    Console.WriteLine("Univeristiy");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
