using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job80
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Random rnd = new Random();

            int count = 0;
            while (sum <= 100)
            {
                count++;
                int num = rnd.Next(1, 21);
                sum += num;
                Console.WriteLine(num);
                Console.WriteLine(count);
                Console.WriteLine(sum);
                Console.WriteLine();
            }
        }
    }
}
