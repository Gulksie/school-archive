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
            Console.Clear();

            //get price of shoes
            double shoes;

            while (true) //part of error checking
            {
                Console.Write("What is the price of the shoes?\t");
                string input = Console.ReadLine();

                try //atempt to convert input to number, and restart if unable to
                {
                    shoes = Convert.ToDouble(input);
                    Console.Clear();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number!\n");
                }
            }

            //calculations
            double hst = shoes * 0.13; //13% hst
            double total = shoes + hst;

            //output
            Console.WriteLine("Bata Shoes\n");
            Console.WriteLine("Cost of Shoes\t$ " + Math.Round(shoes, 2));
            Console.WriteLine("HST\t\t$ " + Math.Round(hst, 2));
            Console.WriteLine("Total\t\t\t$ " + Math.Round(total, 2));
        }
    }
}
