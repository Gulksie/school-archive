using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job72
{
    class Program
    {
        static void Main(string[] args)
        {
            int wins = 0;
            int played = 0;
            for (;;played++)
            {
                Console.WriteLine("What was Newman's score?");
                int newman = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What was the other team's score?");
                int other = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (newman > other)
                    wins++;
                else if (other > newman)
                    break;
            }

            Console.WriteLine("Games played:\t" + played);
            Console.WriteLine("Wins:\t" + wins);
        }
    }
}
