using System;
using System.Linq;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNums = GetUserInput();
            int[] secondNums = GetUserInput();
            int[] sumNums;

            if (firstNums.Length > secondNums.Length)
            {
                sumNums = GetSumOfNums(firstNums, secondNums);
            }
            else
            {
                sumNums = GetSumOfNums(secondNums, firstNums);
            }

            Console.WriteLine(string.Join(" ", sumNums));
        }

        private static int[] GetSumOfNums(int[] arr, int[] shorterArr)
        {
            int[] sumNums = new int[arr.Length];
            for (int i = 0, j = 0; i < arr.Length; i++, j++)
            {
                if (j >= shorterArr.Length)
                {
                    j = 0;
                }

                sumNums[i] = shorterArr[j] + arr[i];
            }

            return sumNums;
        }

        private static int[] GetUserInput()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
