using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job121
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a name");
                names[i] = Console.ReadLine().Trim().ToLower();
            }

            Console.WriteLine("\nUnsorted array");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < names.Length - 1; i++)
                {
                    if (names[i].CompareTo(names[i + 1]) > 0)
                    {
                        flag = true;
                        string tmp = names[i];
                        names[i] = names[i + 1];
                        names[i + 1] = tmp;
                    }
                }
            } while (flag);

            Console.WriteLine("\n Sorted array");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
        }
    }
}
