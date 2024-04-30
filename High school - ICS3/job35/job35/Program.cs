using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("C");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b;
            discriminant -= 4 * a * c;

            string message;
            if (discriminant > 0)
                message = "The equation has two distinct real roots";
            else if (discriminant == 0)
                message = "The equation has two equal roots";
            else
                message = "The roots do not exist";

            Console.WriteLine(message);
        }
    }
}
