using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job103
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Christiano Ronaldo", "Lionel Messi", "Luis Suarez", "Eden Hazard", "Arjen Robben" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
