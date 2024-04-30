using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ojb28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base salary?");
            double base_sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sales?");
            int sales = Convert.ToInt32(Console.ReadLine());

            double commision = (base_sal * sales) / 100;
            if (sales < 10)
                commision = 0;
            double total = base_sal + commision;

            Console.Clear();
            Console.WriteLine(total);
        }
    }
}
