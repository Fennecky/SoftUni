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
            var counter = new long[nums.Max() + 1];
            foreach (var num in nums)
            {
                counter[num]++;
            }
            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > 0)
                {
                    Console.WriteLine($"{i} => {counter[i]}");
                }
            }

        }
    }
}
