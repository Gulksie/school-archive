using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job79
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = new Random().Next(1, 16);
            int guess = 0;

            while (guess != num)
            {
                Console.WriteLine("Enter a guess");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (guess != num)
                {
                    if (guess > num)
                        Console.WriteLine("Guess lower next time");
                    else
                        Console.WriteLine("Guess higher next time");
                }
                else
                    Console.WriteLine("Congrats! You guessed the number!");
            }
        }
    }
}
