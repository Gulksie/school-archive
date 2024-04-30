using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job40
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 800;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Current balance: $" + balance);
                Console.WriteLine("\nWithdraw or derposit?");
                string input = Console.ReadLine().ToLower();

                Console.WriteLine();
                if (input == "quit")
                    break;
                else if (input == "withdraw")
                {
                    Console.WriteLine("How much?");
                    input = Console.ReadLine();

                    try
                    {
                        double withdraw = Convert.ToDouble(input);
                        if (withdraw > balance)
                        {
                            Console.WriteLine("You don't have that much!");
                            continue;
                        }

                        balance -= withdraw;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else if (input == "deposit")
                {
                    Console.WriteLine("How much?");
                    input = Console.ReadLine();

                    try
                    {
                        balance += Convert.ToDouble(balance);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else
                    Console.WriteLine("Invalid input");
            }
        }
    }
}
