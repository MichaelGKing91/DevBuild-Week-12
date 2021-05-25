using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 5, 10, 20, 50, 100, 150 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            var res = from x in nums where x >= 50 select x;
            foreach (int num in nums)
            {
                Console.WriteLine(num);
                    
            }
        }
    }
}
