using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job88
{
    class Program
    {
        static void Main(string[] args)
        {
            int satisfactory = 0;
            int unsatisfactory = 0;
            int excellent = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("What is mark " + i + "?");
                int input;
                try
                {
                    input = Convert.ToInt16(Console.ReadLine());

                    if (input > 100 || input < 0)
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input\n");
                    i--;
                    continue;
                }

                if (input >= 80)
                    excellent++;
                else if (input >= 50)
                    satisfactory++;
                else
                    unsatisfactory++;
            }
            Console.WriteLine("Excellent\t" + excellent);
            Console.WriteLine("Satisfactory\t" + satisfactory);
            Console.WriteLine("Unsatisfactory\t" + unsatisfactory);
        }
    }
}
