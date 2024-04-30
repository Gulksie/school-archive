using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job106
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence.");
            string sentence = Console.ReadLine().ToUpper();

            Console.WriteLine("Now enter a word.");
            string word = Console.ReadLine().ToUpper();

            bool contains = false;
            if (sentence.Contains(word))
                contains = true;

            
        }
    }
}
