using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job122
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name, or type 'STOP' to stop");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "STOP")
                    break;

                names.Add(input.ToLower());
            }

            Console.WriteLine("Unsorted list:");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < names.Count - 1; i++)
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

            Console.WriteLine("Sorted list");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
        }
    }
}
