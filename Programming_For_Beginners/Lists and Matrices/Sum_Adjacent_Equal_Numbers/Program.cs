using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var previousNum = 0;

            while (previousNum < nums.Count - 1)
            {
                if (nums[previousNum] == nums[previousNum + 1])
                {
                    nums[previousNum] = nums[previousNum] + nums[previousNum + 1];
                    nums.RemoveAt(previousNum + 1);
                    previousNum--;
                    if (previousNum < 0)
                    {
                        previousNum = 0;
                    }
                }
                else
                {
                    previousNum++;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
