using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace job125
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"W:\files\olympicCountries.txt");
            List<string> countries = new List<string>();

            string temp = sr.ReadToEnd();
            foreach(string i in temp.Split(new[] {"\n", "\r\n"}, StringSplitOptions.RemoveEmptyEntries))
            {
                countries.Add(i);
            }

            //sort the sort
            bool flag;
            do
            {
                flag = false;

                for (int i = 0; i < countries.Count - 1; i++)
                {
                    if (countries[i].CompareTo(countries[i + 1]) > 0)
                    {
                        flag = true;
                        string tmp = countries[i];
                        countries[i] = countries[i + 1];
                        countries[i + 1] = tmp;
                    }
                }
            } while (flag);

            foreach (string i in countries)
            {
                Console.WriteLine(i);
            }
        }
    }
}
