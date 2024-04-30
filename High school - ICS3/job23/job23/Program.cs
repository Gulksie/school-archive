using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job23
{
    class Program
    {
        static void Main(string[] args)
        {
            //get name
            string name = input("What is your name?\t");

            //get rate of pay
            double rate;
            while (true)
            {
                string in_ = input("\nWhat is your rate of pay?\t");

                try
                {
                    rate = Convert.ToDouble(in_);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number!");
                }
            }

            //get hours worked
            int hours;
            while (true)
            {
                string in_ = input("\nhow many hours have you worked?\t");

                try
                {
                    hours = Convert.ToInt32(in_);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number!");
                }
            }

            //deductions
            double cpp = 3.5;
            double ei = 8.0;
            double benefits = 10.6;
            double deductions = cpp + ei + benefits;

            //calculations
            double gross = hours * rate;
            double net = gross - deductions;

            //output
            Console.WriteLine("Pay for " + name);
            Console.WriteLine("\nHours worked\t" + hours);
            Console.WriteLine("Rate of pay\t" + rate);
            Console.WriteLine("Gross Pay\t\t$" + Math.Round(gross, 2));
            Console.WriteLine("\nDeductions:");
            Console.WriteLine("CPP\t" + cpp);
            Console.WriteLine("EI\t" + ei);
            Console.WriteLine("Benifits\t" + benefits);
            Console.WriteLine("Net Pay\t\t$" + net);
        }

        static string input(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
