using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//assignment #2A; ICS3U1
//Michael Gulka; 18/10/17
//The purpose of this program is to calculate the cost of a ticket based on a user inputted age
namespace assign2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //decalre vars
            int age;
            string cost;

            //get age
            Console.WriteLine("How old is the person the ticket is being bought for?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            //get ticket price
            if (age < 0)
                Console.WriteLine("Invalid input");
            else
            {
                if (age <= 2)
                    cost = "free";
                else if (age <= 11)
                    cost = "$15.50";
                else if (age <= 64)
                    cost = "$35.95";
                else
                    cost = "$20.50";

                //output
                Console.WriteLine("The ticket is " + cost + ".");
            }
        }
    }
}
