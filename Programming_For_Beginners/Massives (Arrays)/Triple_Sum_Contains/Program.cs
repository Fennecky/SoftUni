using System;
using System.Globalization;
using System.Linq;

namespace Triple_Sum_Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = GetUserInput();
            CheckTripleSum(nums);
        }

        private static void CheckTripleSum(int[] nums)
        {
            bool foundTripleSum = false;
            for (int left = 0; left < nums.Length; left++) 
            {
                for (int right = left + 1; right < nums.Length; right++) 
                {
                    int sum = nums[left] + nums[right];
                    if (SumHasMatches(nums, sum))
                    {
                        foundTripleSum = true;
                        PrintSum(nums[left], nums[right]);
                    }
                }
            }

            if (!foundTripleSum)
            {
                Console.WriteLine("No");
            }
        }

        private static bool SumHasMatches(int[] nums, int sum)
        {
            return nums.Contains(sum);
            
        }

        private static void PrintSum(int left, int right)
        {
            Console.WriteLine("{0} + {1} == {2}", left, right, left + right);
        }

        private static int[] GetUserInput()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
