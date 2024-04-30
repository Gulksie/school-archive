using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job21
{
    class Program
    {
        static void Main(string[] args)
        {
            int cents;
            int remainder;
            while (true)
            {
                Console.Write("Enter an amount less than $1 in cents\t");
                string input = Console.ReadLine();

                try
                {
                    cents = Convert.ToInt32(input);
                    if (cents >= 100)
                        Console.WriteLine("That's not less than $1\n");
                    else
                        break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number\n");
                }
            }

            int quarters = cents / 25;
            remainder = cents % 25;

            int dimes = remainder / 10;
            remainder %= 10;

            int nickles = remainder / 5;
            remainder %= 5;

            int pennies = remainder;

            string out_ = "";

            if (quarters > 0)
                out_ += "Quarters: " + quarters + '\n';
            if (dimes > 0)
                out_ += "Dimes: " + dimes + '\n';
            if (nickles > 0)
                out_ += "Nickels: " + nickles + '\n';
            if (pennies > 0)
                out_ += "Pennies: " + pennies + '\n';

            Console.WriteLine(out_);
        }
    }
}
