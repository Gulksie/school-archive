using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Byte> marks = new List<byte>();
            int count = 1;
            while (true)
            {
                Console.WriteLine("Mark " + count);
                string input = Console.ReadLine();
                if (input.ToLower() == "stop")
                    break;

                marks.Add(Convert.ToByte(input));
                count++;
            }
            Console.Clear();

            count = 1;
            double av = 0;
            foreach (Byte i in marks)
            {
                Console.WriteLine("Mark " + count + " is: " + i.ToString() + "%");
                av += i;
                count++;
            }

            av = Math.Round(av / marks.Count, 0);
            Console.WriteLine("The avarage of the marks is:    " + av.ToString() + "%");
        }
    }
}
