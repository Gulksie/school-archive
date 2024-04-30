using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job81
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many items did you buy?");
            int items = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much did it cost?");
            double cost = Convert.ToDouble(Console.ReadLine());

            double total = items * cost;

            if (items >= 10 && total >= 50)
                cost -= cost * 0.12;


        }
    }
}
