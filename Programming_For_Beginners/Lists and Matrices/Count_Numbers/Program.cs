using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            nums.Sort();

            // 2 2 2 2 3 3 4
            //       l n
            long lastNum = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Count; i++)
            {
                if (lastNum == nums[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{lastNum} -> {count}");
                    count = 1;
                    lastNum = nums[i];
                }
            }
            //var counter = new long[nums.Max() + 1];
            //foreach (var num in nums)
            //{
            //    counter[num]++;
            //}

            //for (int i = 0; i < counter.Length; i++)
            //{
            //    if (counter[i] > 0)
            //    {
            //        Console.WriteLine($"{i} -> {counter[i]}");
            //    }
            //}
        }
    }
}
