using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace job107
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[8];
            Random rnd = new Random();
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 101);
                Console.WriteLine(nums[i]);
                sum += nums[i];
            }
            sum /= nums.Length;

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
