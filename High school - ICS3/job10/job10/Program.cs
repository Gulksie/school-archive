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
            short years;

            while (true)
            {
                Console.Write("How old are you(years) ");
                try
                {
                    years = Convert.ToInt16(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a valid number");
                }
            }

            Console.WriteLine("Months " + years * 12);
            int days = (years * 256 + (int)Math.Floor(years/4.0));
            Console.WriteLine("Days " + days);
            Console.WriteLine("Hours " + days*24);
            Console.WriteLine("Minutes " + days*24*60);
        }
    }
}
