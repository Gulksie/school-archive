using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job27
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

                if (age <= 12)
                    Console.WriteLine("Child ticket: $12");
                else if (age < 65)
                    Console.WriteLine("Adult ticket: $15");
                else
                    Console.WriteLine("Senior ticket: $10)");
            }
        }
    }
}
