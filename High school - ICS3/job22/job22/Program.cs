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
            int tiles;
            while (true)
            {
                Console.Write("How many tiles?\t");
                string input = Console.ReadLine();

                try
                {
                    tiles = Convert.ToInt32(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number\n");
                }
            }

            int boxes = tiles / 10;
            int remainder = tiles %10;

            Console.WriteLine("You will need to buy " + boxes + " boxes and will have " + remainder + 
                " tiles left over");
        }
    }
}
