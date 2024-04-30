using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment4B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            //declare varibles and assign them 0
            int rebellion = 0;
            int pp = 0;
            int depression = 0;
            int curiosity = 0;
            int other = 0;

            for (int i = 0; i < 10; i++) //ask 10 times
            {
                Console.WriteLine("According to you, why do teenagers start smoking?");

                Console.WriteLine(@"1. Rebellion
2. Peer pressure
3. Depression
4. Curiosity
5. Other reasons
");

                string input = Console.ReadLine().ToLower(); //get users reply

                switch (input)//check input and add to its category
                {
                    case "rebellion":
                        rebellion++;
                        break;
                    case "1":
                        rebellion++;
                        break;
                    case "peer pressure":
                        pp++;
                        break;
                    case "2":
                        pp++;
                        break;
                    case "depression":
                        depression++;
                        break;
                    case "3":
                        depression++;
                        break;
                    case "curiosity":
                        curiosity++;
                        break;
                    case "4":
                        curiosity++;
                        break;
                    case "other":
                        other++;
                        break;
                    case "other reasons":
                        other++;
                        break;
                    case "5":
                        other++;
                        break;
                    default: //if it's not any of the above, its not valid input
                        Console.WriteLine("Invalid input");
                        i--;//ask the question an aditional time (because of invalid input)
                        break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Rebellion: " + rebellion);
            Console.WriteLine("Peer pressure: " + pp);
            Console.WriteLine("Depression: " + depression);
            Console.WriteLine("Curiosity: " + curiosity);
            Console.WriteLine("Other reasons: " + other);
        }
    }
}
