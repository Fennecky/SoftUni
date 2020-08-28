using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = GetUserInput();
            double[] roundedNums = SetValueToNumsLenght(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                RoundDoubleNums(nums, roundedNums, i);
                Console.WriteLine("{0} ==> {1}", nums[i], roundedNums[i]);
            }
        }

        private static double[] SetValueToNumsLenght(double[] nums)
        {
            return new double[nums.Length];
        }

        private static void RoundDoubleNums(double[] nums, double[] roundedNums, int i)
        {
            roundedNums[i] = Math.Round(nums[i], MidpointRounding.AwayFromZero);
        }

        private static double[] GetUserInput()
        {
            return Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        }
    }
}
