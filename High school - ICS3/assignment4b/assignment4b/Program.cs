using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//assignment #4B; ICS3U1
//Michael Gulka; 11/23/17
//The purpose of this program is to calculate how long a farm can last with an increasing amount of food
//and double the animals every hour
namespace assignment4b
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours; //declare hours varible for later
            int food = 4000; //start with 4000 pounds of food
            int animals = 0; //declare animals

            while (animals < 1) //get # of animals
            {
                Console.Clear();
                Console.WriteLine("How many animals are on the farm?");

                bool error = false; //varible for if input is invalid
                try
                {
                    animals = Convert.ToInt32(Console.ReadLine()); //get user input for # of animals
                    Console.WriteLine();

                    if (animals < 1) //check if animals is a positive value
                        error = true;
                }
                catch (Exception) //input isn't a number
                {
                    error = true;
                }

                if (error)
                {
                    Console.WriteLine("Invalid input.\n");
                    Console.ReadKey(true);
                }
            }
            
            //sucessfully got animal input
            hours = 0; 
            do
            {
                //output data on food, animals, hour, etc.
                Console.WriteLine("Hour " + hours);
                Console.WriteLine("Food: " + food + " pounds");
                Console.WriteLine("Animals : " + animals);
                Console.WriteLine("There are " + (food - animals) + " more pounds of food than animals");
                Console.WriteLine();

                hours++; //add an hour to the total
                animals *= 2; //double the animals
                food += 1000; //add 1000 more food
            }
            while (food > animals); //do this while there's more food than animals

            Console.WriteLine("The food lasted for " + hours + " hours.");
        }
    }
}
