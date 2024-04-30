using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job77
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine(rnd.Next(1, 21));
            Console.WriteLine(rnd.Next(1, 250));
            Console.WriteLine(rnd.Next(10, 100));
        }
    }
}
