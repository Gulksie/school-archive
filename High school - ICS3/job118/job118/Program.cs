using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job118
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter a number in between 1 and 50");

                try
                {
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    if (tmp > 50 || tmp < 1)
                        throw new Exception();

                    marks[i] = tmp;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input.");
                    i--;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Original list:");
            foreach (int i in marks)
            {
                Console.WriteLine(i);
            }

            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < marks.Length - 1; i++)
                {
                    if (marks[i] > marks[i + 1])
                    {
                        flag = true;
                        int tmp = marks[i];
                        marks[i] = marks[i + 1];
                        marks[i + 1] = tmp;
                    }
                }
            } while (flag);

            Console.WriteLine("Sorted list");
            foreach (int i in marks)
            {
                Console.WriteLine(i);
            }

            Console.Write("\nAvarage: ");
            int sum = 0;
            foreach (int i in marks)
            {
                sum += i;
            }
            Console.WriteLine(sum/marks.Length);
        }
    }
}
