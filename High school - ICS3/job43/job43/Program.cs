using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("What's your favorite sport?");
            string sport = Console.ReadLine();

            Console.WriteLine("\nHow many times should it be printed?");
            int times = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(sport);
            }
        }
    }
}
