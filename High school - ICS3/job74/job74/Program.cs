using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job74
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 2; sum <= 100; i+=2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        //the one-liner
        static string input(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
