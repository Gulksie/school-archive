using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //get distance
            int distance;
            while (true)
            {
                string in_ = input("How much distance?\t");

                try
                {
                    distance = Convert.ToInt32(in_);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number.\n");
                }
            }

            //get speed
            int speed;
            while (true)
            {
                string in_ = input("How fast were you going (km/h)?\t");

                try
                {
                    speed = Convert.ToInt32(in_);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number.\n");
                }
            }

            //get mileage
            double mileage;
            while (true)
            {
                string in_ = input("Mileage?\t");

                try
                {
                    mileage = Convert.ToDouble(in_);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number.\n");
                }
            }

            //cost/litre
            double cpL;
            while (true)
            {
                string in_ = input("Cost per Litre?\t");

                try
                {
                    cpL = Convert.ToDouble(in_);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number.\n");
                }
            }
            Console.Clear();

            double time = distance / (double)speed;
            double lU = distance * mileage;
            double tripCost = lU * cpL;

            Console.WriteLine("Time:\t" + time + " hours");
            Console.WriteLine("Cost:\t$" + tripCost);
        }

        static string input(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
