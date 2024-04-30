using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job100
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            while (true)
            {
                Console.WriteLine("Enter a phone number");
                string input = Console.ReadLine();

                if (input.Length != 12)
                {
                    Console.WriteLine("Invalid input\n");
                    continue;
                }

                try
                {
                    int count = 0;
                    foreach(string i in input.Split(' ', '-'))
                    {
                        Convert.ToInt32(i);
                        if (count > 2 || (count == 2 && i.Length != 4) || (count < 2 && i.Length != 3))
                            throw new Exception();
                        count++;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input\n");
                    continue;
                }

                num = input;
                break;
            }

            Console.WriteLine("Area code: " + num.Substring(0, 3));
            Console.WriteLine("Phone number: " + num.Substring(4));
        }
    }
}
