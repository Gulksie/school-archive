using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sweets;
            while (true)
            {
                Console.Write("How many sweets do you have?\t");
                string input = Console.ReadLine();

                try
                {
                    sweets = Convert.ToInt32(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a whole number!\n");
                }
            }

            int perPerson = sweets / 5;
            int remainder = sweets % 5;
            Console.WriteLine("Each person will get " + perPerson + " sweets and there will be " +
                remainder + " left over");
        }
    }
}
