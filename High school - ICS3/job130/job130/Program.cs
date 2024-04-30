using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace job130
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"W:\files\mergeStudentNames.txt");
            List<string> names = new List<string>();
            List<string> group1 = new List<string>();
            List<string> group2 = new List<string>();
            List<string> group3 = new List<string>();

            foreach (string i in sr.ReadToEnd().Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                names.Add(i);
            }
            sr.Close();

            sr = new StreamReader(@"W:\files\mergeGroupNo.txt");
            int count = 0;
            foreach (string i in sr.ReadToEnd().Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (i == "1")
                    group1.Add(names.ElementAt(count));
                else if (i == "2")
                    group2.Add(names.ElementAt(count));
                else
                    group3.Add(names.ElementAt(count));

                count++;
            }

            Console.WriteLine("Group 1: ");
            foreach (string name in group1)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nGroup 2: ");
            foreach (string name in group2)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nGroup 3: ");
            foreach (string name in group3)
            {
                Console.WriteLine(name);
            }
        }
    }
}
