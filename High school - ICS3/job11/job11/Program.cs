using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job11
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = raw_input("Pay Cheque for:\t\t");
            double rate = Convert.ToDouble(raw_input("\nHourly Rate:\t\t$ "));
            int hours = Convert.ToInt32(raw_input("Hours Worked:\t\t"));
            Console.WriteLine("\nTotal Pay:\t\t$ " + Math.Round(rate * hours, 2).ToString());
        }

        static string raw_input(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
