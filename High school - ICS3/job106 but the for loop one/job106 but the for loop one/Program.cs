using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job106
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] things = new string[5];
            int longest = 0;

            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine("Enter a favorite thing");

                things[i] = Console.ReadLine();

                if (things[i].Length > longest)
                    longest = things[i].Length;
            }

            longest += 15;
            foreach (string i in things)
            {
                Console.Write(i.ToLower());
                Console.CursorLeft = longest;
                Console.WriteLine(i);
            }
        }
    }
}
