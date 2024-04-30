using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job116
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number");

                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                    i--;
                }

                Console.WriteLine();
            }

            Console.Clear();
            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        flag = true;
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
            }
            while (flag);

            Console.WriteLine("The list normal");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The list backwards");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
