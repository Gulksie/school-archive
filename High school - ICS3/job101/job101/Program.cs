using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job101
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            while (true)
            {
                Console.WriteLine("Enter a word with an odd number of charicters");

                word = Console.ReadLine();

                if (word.Length % 2 != 0)
                {
                    break;
                }
                Console.WriteLine("invalid input\n");
            }

            Console.WriteLine(word);
            Console.WriteLine(word.ElementAt((word.Length-1)/2));
        }
    }
}
