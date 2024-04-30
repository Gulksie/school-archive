using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job108
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number.");

                try
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                    i--;
                }

                Console.WriteLine();
            }

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            
            for (int i = nums.Length-1; i >= 0; i--)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
