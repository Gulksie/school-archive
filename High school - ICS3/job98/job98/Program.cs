using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job98
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string");
            string input = Console.ReadLine().ToLower();

            int a = 0;
            int vowel = 0;
            foreach (char i in input)
            {
                if (i == 'a')
                    a++;

                if (new char[] { 'a', 'e', 'i', 'o', 'u' }.Contains(i))
                {
                    vowel++;
                }
            }

            Console.WriteLine("Number of 'a's: " + a);
            Console.WriteLine("Number of vowels: " + vowel);
        }
    }
}
