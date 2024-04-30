using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job129
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(@"W:\files\hockey.txt");
            List<string> names = new List<string>();
            List<uint> goals = new List<uint>();

            uint high = 0;
            uint low = uint.MaxValue;
            foreach (string i in sr.ReadToEnd().Split(new[] {"\n", "\r\n"}, StringSplitOptions.RemoveEmptyEntries))
            {
                try
                {
                    uint tmp = Convert.ToUInt32(i);
                    goals.Add(tmp);

                    if (tmp > high)
                        high = tmp;
                    if (tmp < low)
                        low = tmp;
                }
                catch (FormatException)
                {
                    names.Add(i);
                }
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("Name: " + names.ElementAt(i) + "\tGoals: " + goals.ElementAt(i));
            }

            Console.WriteLine();
            Console.WriteLine("Highest: " + names.ElementAt(goals.IndexOf(high)) + " with " + high + " goals.");
            Console.WriteLine("Lowest: " + names.ElementAt(goals.IndexOf(low)) + " with " + low + " goals.");
        }
    }
}
