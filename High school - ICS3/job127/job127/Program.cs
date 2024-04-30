using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace job127
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"W:\files\friends.txt");

            while (true)
            {
                Console.WriteLine("Enter a freind's name, or type stop to stop");
                string input = Console.ReadLine().Trim();

                if (input == "stop")
                    break;

                sw.WriteLine(input);
            }
            sw.Close();

            StreamReader sr = new StreamReader(@"W:\files\friends.txt");
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
