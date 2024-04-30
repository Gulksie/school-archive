using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job105
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a grade");

                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input > 100 || input < 0)
                        throw new Exception();

                    marks[i] = input;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                    i--;
                }
            }

            Console.WriteLine();
            int sum = 0;
            foreach (int i in marks)
            {
                sum += i;
            }

            sum /= marks.Length;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine((i+1) + ".\t" + marks[i]);
            }
            Console.WriteLine("Average:\t" + sum);
        }
    }
}
