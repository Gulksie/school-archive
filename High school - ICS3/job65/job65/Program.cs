using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job65
{
    class Program
    {
        static void Main(string[] args)
        {
            int div = 0;
            int cat = 0;
            int des = 0;
            int spi = 0;
            int ann = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(@"Which is your favorite 2014 movie?
1. Divergent
2. Catching Fire
3. The Desolation of Smaug
4. The Amazing Spiderman 2
5. Annabelle
Please enter the number of your choice.
");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (input)
                {
                    default:
                        Console.WriteLine("Not valid.\n");
                        i--;
                        break;
                    case 1:
                        div++;
                        break;
                    case 2:
                        cat++;
                        break;
                    case 3:
                        des++;
                        break;
                    case 4:
                        spi++;
                        break;
                    case 5:
                        ann++;
                        break;
                }

            }

            Console.WriteLine("Divergent " + div);
            Console.WriteLine("Catching fire " + cat);
            Console.WriteLine("The Desolation of Smaug " + des);
            Console.WriteLine("The Amazing Spiderman 2 " + spi);
            Console.WriteLine("Annabelle " + ann);
        }
    }
}
