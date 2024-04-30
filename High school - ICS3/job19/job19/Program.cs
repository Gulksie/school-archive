using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job19
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs;

            while (true)
            {
                Console.Write("How many eggs do you have?\t");
                string input = Console.ReadLine();

                try
                {
                    eggs = Convert.ToInt32(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a whole number!\n");
                }
            }

            int cartons = eggs / 12;
            Console.WriteLine("You will have " + cartons + " cartons.");
        }
    }
}
