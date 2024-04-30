using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job93
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a word");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input.ElementAt(0) == 't')
                    count++;
            }

            Console.WriteLine("Amount of time an input started with 't': " + count);
        }
    }
}
