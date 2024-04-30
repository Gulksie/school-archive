using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job20
{
    class Program
    {
        static void Main(string[] args)
        {
            int ppl;

            while (true)
            {
                Console.Write("How many parishioners?\t");
                string input = Console.ReadLine();

                try
                {
                    ppl = Convert.ToInt32(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a whole number!\n");
                }
            }

            int buses = ppl / 25;
            int remainder = ppl % 25;

            Console.WriteLine("There will be " + buses + " full buses and " + remainder + " parishoners left.");
        }
    }
}
