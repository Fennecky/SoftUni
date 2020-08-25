using System;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var nums = new long[n];

            nums[0] = 1;
            for (long i = 1; i < n; i++)
            {
                long sum = 0;
                for (long perv = i - k; perv <= i-1; perv++)
                {
                    if(perv >= 0)
                    {
                        sum += nums[perv];
                    }
                }
                nums[i] = sum;
            }
            for (int rotation = 0; rotation < n; rotation++)
            {
                Console.Write(nums[rotation] + " ");
            }
        }
    }
}
