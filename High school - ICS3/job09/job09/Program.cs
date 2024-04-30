using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job09
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            while (true)
            {
                Console.Write("Radius: ");
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number" + Environment.NewLine);
                }
            }

            double area = Math.PI * (radius * radius);
            Console.WriteLine("Area: " + Math.Round(area, 2).ToString() + " square meters");
        }
    }
}
