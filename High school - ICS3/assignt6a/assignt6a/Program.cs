using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//assign6a, Michael Gulka, ICS 3U1
//the purpose of this job is to manipulate a string to provide various outputs
namespace assignment6a
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare varible
            string word;

            //assign varibles
            Console.WriteLine("Enter a word");
            word = Console.ReadLine();

            //output
            Console.WriteLine("\nLength of word: " + word.Length);
            Console.WriteLine("First charicter of word: " + word.Substring(0, 1));
            Console.WriteLine("Last charicter of word: " + word.Substring(word.Length-1));
            Console.WriteLine("Word in all lower case: " + word.ToLower());
            
            //display word with each charicter on a new line
            Console.WriteLine("\nWord with each charicter on a new line:");
            foreach (char i in word)
            {
                Console.WriteLine(i);
            }

            //transition to part 2
            Console.Write("Press a key to continue to part 2");
            Console.ReadKey(true);
            Console.WriteLine("\n");

            //part 2
            //declare varibles
            string sentence;
            int vowels = 0;
            int consonants = 0;

            //assign varibles
            sentence = "To extend our reach to the stars above";

            //calculate vowels and constanats
            foreach (char i in sentence)
            {
                if (i == ' ') //if the charicter is a space, go to next char
                    continue;
                else if (new char[] { 'a', 'e', 'i', 'o', 'u' }.Contains(i)) //checks if the char is in an array of vowels and if so, add one to
                    //vowels
                    vowels++;
                else //because there is no punctuation in the sentence, the only option left is that the char is a constantant, so add one
                    consonants++;
            }

            //output
            Console.WriteLine("Sentence: " + sentence);
            Console.WriteLine("Vowels: "  + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }
    }
}
