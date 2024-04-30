using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job126
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(@"W:\files\scores.txt");
            List<int> scores = new List<int>();

            int count = 0;
            int avar = 0;
            foreach (string i in sr.ReadToEnd().Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                try
                {
                    int num = Convert.ToInt32(i.Trim());
                    scores.Add(num);
                    avar += num;
                    Console.WriteLine(num);
                }
                catch (Exception)
                {
                    Console.WriteLine("Couldn't convert item at line " + count);
                }
                count++;
            }

            avar /= scores.Count;
            Console.WriteLine("\r\n" + avar);
        }
    }
}
