using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job92
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num1 = 0;
            int num2 = 0;
            int firsts = 0;
            bool correct = true;

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                if (correct)
                {
                    num1 = rnd.Next(1, 11);
                    num2 = rnd.Next(1, 11);
                }

                int input;
                while (true)
                {
                    Console.Write(num1 + " + " + num2 + " = ");

                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input\n");
                    }
                }
                Console.WriteLine();

                if (input == num1 + num2)
                {
                    Console.WriteLine("CORRECT");
                    if (correct)
                        firsts++;

                    correct = true;
                }
                else
                {
                    Console.WriteLine("INCOREECT");
                    correct = false;
                    i--;
                }
                Console.ReadKey(true);
            }

            Console.WriteLine("\nCongrats! You finished!");
            Console.WriteLine("Number of correct first guesses: " + firsts);
        }
    }
}
