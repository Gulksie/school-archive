using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("What suit");
            string suit = Console.ReadLine().ToLower();

            if (suit == "hearts" || suit == "diamonds")
                Console.WriteLine("Red");
            else if (suit == "spades" || suit == "clubs")
                Console.WriteLine("Black");
            else
                Console.WriteLine("Invalid input");
        }
    }
}
