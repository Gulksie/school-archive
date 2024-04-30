using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //decalre vars
            int length = 20;
            int width = 16;
            float costPerUnit = 12.99f;
            int area;
            float totalCost;

            //do ze calculationzez
            area = length * width;
            totalCost = (float)area * costPerUnit;

            //output
            Console.WriteLine(@"The total cost of the grass
Cost per square meter:  $" + costPerUnit + @"
Length: " + length + @"
Width:  " + width + @"
Area:   " + area + @"
Total Cost: $ " + Math.Round(totalCost, 2).ToString());
        }
    }
}
