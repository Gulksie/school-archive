using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job123
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "PONIKAROVSKY", "STEMPNIAK", "HAGMAN", "STAJAN", "KESSEL" };
            int[] goals = new int[] { 9, 6, 14, 8, 10 };

            bool flag;
            do
            {
                flag = false;

                for (int i = 0; i < goals.Length-1; i++)
                {
                    if (goals[i] > goals[i + 1])
                    {
                        flag = true;

                        int tmp = goals[i];
                        goals[i] = goals[i + 1];
                        goals[i + 1] = tmp;

                        string temp = names[i];
                        names[i] = names[i + 1];
                        names[i + 1] = temp;
                    }
                }
            } while (flag);

            Console.WriteLine("Sorted list:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name: " + names[i] + "\tGoals: " + goals[i]);
            }
        }
    }
}
