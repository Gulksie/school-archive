using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job97
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text.");

            string txt = Console.ReadLine();

            int count = 0;
            foreach (string i in txt.Split(' '))
            {
                count++;
            }

            Console.WriteLine("Words: " + count);
        }
    }
}
