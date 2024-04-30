using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job84
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark;

            for (int i = 1; 1 <= 4; i++)
            {
                Console.WriteLine("What is you mark?");
                mark = Convert.ToInt32(Console.ReadLine());

                while (mark < 1 || mark > 100)
                {
                    Console.WriteLine("What was actually your mark?");
                    mark = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ight");
            }
        }
    }
}
