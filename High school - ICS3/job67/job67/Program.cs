using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job67
{
    class Program
    {
        static void Main(string[] args)
        {
            int pizza = 0;
            int gyros = 0;
            int hamburgers = 0;
            int panzarotti = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(@"What is your favorite fast food?
1. Pizza
2. Gyros
3. Hamburgers
4. Panzarotti
and if ur not a teenage boy u better frick off");

                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input > 4 || input < 1)
                        throw new System.Exception();

                    switch (input)
                    {
                        case 1:
                            pizza++;
                            break;
                        case 2:
                            gyros++;
                            break;
                        case 3:
                            hamburgers++;
                            break;
                        case 4:
                            panzarotti++;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                    i--;
                }
            }
        }
    }
}
