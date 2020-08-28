using System;
using System.Linq;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = GetUserInput();

            for (int i = 0; i < nums.Length / 2; i++)
            {
                ReverseNumbers(nums, i, nums.Length - i - 1);
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        private static string[] GetUserInput()
        {
            return Console.ReadLine().Split(' ').ToArray();
        }

        private static void ReverseNumbers(string[] nums, int i, int j)
        {
            var previousNumber = nums[i];
            nums[i] = nums[j];
            nums[j] = previousNumber;
        }
    }
}
