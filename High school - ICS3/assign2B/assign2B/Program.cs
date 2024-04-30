using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//assign 2B; ICS3U1
//Michael Gulka; 18/10/17
//The purpose of this program is to calculate an average from a user input and tell the user that average
//as well as if they have a passing or failing average
namespace assign2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //decalre vars
            int[] marks = new int[3];
            double average;

            //get marks
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("What is mark " + i + "?");

                marks[i - 1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            //calculate average
            average = 0;
            foreach (int i in marks)
            {
                average += i;
            }
            average /= marks.Length;

            //output
            Console.Write("Your average is " + Math.Round(average, 1) + "%. ");

            if (average >= 50)
                Console.WriteLine("You have a passing average.");
            else
                Console.WriteLine("Sorry, you have a failing average.");
        }
    }
}
