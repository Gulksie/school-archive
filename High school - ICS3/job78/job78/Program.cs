using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job78
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int count = 0;
            Random rnd = new Random();

            do
            {
                num1 = rnd.Next(0, 16);
                num2 = rnd.Next(0, 16);
                Console.WriteLine("Num 1 = " + num1 + "\nNum 2 = " + num2);
                Console.WriteLine();
                count++;
            }
            while (num1 != num2);
            Console.WriteLine("It took " + count + " tries.");
        }
    }
}
