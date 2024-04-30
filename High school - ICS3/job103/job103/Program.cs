using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Input a first and last name seperated by a space");
            string input = Console.ReadLine();

            string[] names = input.ToLower().Split(' ');

            string initials = "";
            byte count= 0;
            foreach (string name in names)
            {
                char first = name.ElementAt(0);
                first = (char)((byte)first - 32);
                initials += first;

                names[count] = first + name.Substring(1);
                count++;
            }

            Console.WriteLine(names[0] + " " + names[1]);
            Console.WriteLine(initials);
        }
    }
}
