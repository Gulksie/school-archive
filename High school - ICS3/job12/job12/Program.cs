using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your phone number?");
            string phoneNum = Console.ReadLine();

            for (int i = 0; i < 40; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine("\n\t\t" + name);
            Console.WriteLine("\t" + phoneNum);
            for (int i = 0; i < 40; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
