using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job25
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                //get age
                int age;
                while (true)
                {
                    Console.Write("How old are you?\t");
                    string input = Console.ReadLine();

                    try
                    {
                        age = Convert.ToInt32(input);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Not a number!\n");
                    }
                }

                if (age >= 18)
                    Console.WriteLine("You may see the movie by thyself");
                else
                    Console.WriteLine("You need a parent to come with you to see the movie");

                Console.ReadLine();
            }
        }
    }
}
