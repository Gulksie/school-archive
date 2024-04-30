using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine().ToLower();

            int ing = 0;
            foreach (string i in input.Split(' '))
            {
                string j = i;
                byte a = 47;
                if (new char[] {'.', ',', ';', ':', '!', '?', '"', (char)a}.Contains(
                    i.ElementAt(i.Length-1)))
                    j = i.Substring(0, i.Length-2);

                try
                {
                    if (j.Substring(j.Length - 3) == "ing")
                        ing++;
                }
                catch (Exception) { }
            }

            Console.WriteLine("Number of 'ing's: " + ing);
        }
    }
}
