using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numerator:\t");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDenominator:\t");
            double den = Convert.ToDouble(Console.ReadLine());

            string total;
            try
            {
                total = Convert.ToString(num / den);
            }
            catch (Exception)
            {
                total = "Denomerator is probably 0";
            }

            Console.WriteLine(total);
        }
    }
}
