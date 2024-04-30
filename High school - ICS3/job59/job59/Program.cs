using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job59
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(i + " - " + j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
