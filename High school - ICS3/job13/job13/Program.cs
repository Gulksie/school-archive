using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job13
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = input("What is your first name?\t");
            string name2 = input("\nWhat is your last name?\t");
            string subject = input("\nWhat subject?\t");
            string grade = input("\nWhat is your grade?\t");
            
            for (int i = 0; i < 25; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine("\nName:\t" + name1 + ' ' + name2);
            Console.WriteLine("Subject:\t" + subject);
            Console.WriteLine("Grade:\t" + grade);
            for (int i = 0; i < 25; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        static string input(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
