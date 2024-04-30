using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            while (true)
            {
                Console.WriteLine("Enter a 3 digit number");

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input > 999 || input < 100)
                        throw new Exception();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input\n");
                    continue;
                }
            }

            string reverseInput_ = "";
            for (int i = 2; i >=0; i--)
            {
                reverseInput_ += input.ToString().ElementAt(i);
            }

            int reverseInput = Convert.ToInt32(reverseInput_);
            Console.WriteLine(input + " + " + reverseInput_ + " = " + (input + reverseInput));
        }
    }
}
