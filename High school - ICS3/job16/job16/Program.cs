using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //job 3 2.0??
            //what am i supposed to put??
            //idk i guess ill just put this
            double radius;
            while (true)
            {
                Console.WriteLine("Radius:");
                string input = Console.ReadLine();
                try
                {
                    radius = Convert.ToDouble(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number!\n");
                }
            }

            Console.WriteLine();
            double volume = 4 / 3.0 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("The volume is " + Math.Round(volume, 1) + " units squared");
        }
    }
}
