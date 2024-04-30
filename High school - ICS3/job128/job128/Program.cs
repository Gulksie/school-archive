using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job128
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(@"W:\files\classMark.txt");
            List<string> names = new List<string>();
            List<int> marks = new List<int>();

            int avarage = 0;
            foreach (string i in sr.ReadToEnd().Split(new[] {"\n", "\r\n"}, StringSplitOptions.RemoveEmptyEntries))
            {
                try
                {
                    int tmp = Convert.ToInt32(i);
                    marks.Add(tmp);
                    avarage += tmp;
                }
                catch (FormatException)
                {
                    names.Add(i);
                }
            }

            avarage /= marks.Count;

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("Name: " + names.ElementAt(i) + "\tMark: " + marks.ElementAt(i));
            }
        }
    }
}
