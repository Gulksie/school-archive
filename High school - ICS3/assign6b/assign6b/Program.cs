using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//assign6b, Michael Gulka, ICS 3U1
//the purpose of this assignment is to take an input, make it uppercase, and then print it forwards in backwards with a different length
namespace assign6b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //declare varibles
            string word;
            string backwardsWord;

            //assign varibles
            Console.WriteLine("Please enter a word.");
            word = Console.ReadLine().ToUpper();

            //get the word backwards
            backwardsWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                backwardsWord += word[i];
            }

            //output
            for (int i = word.Length; i >= 0; i--) //regular word
            {
                string str = word.Substring(0, i);
                Console.WriteLine(str);
            }

            for (int i = 0; i <= backwardsWord.Length; i++) //backwards word (I have plenty of time to do this
            {
                string str = backwardsWord.Substring(0, i);
                Console.WriteLine(str);
            }
        }
    }
}
