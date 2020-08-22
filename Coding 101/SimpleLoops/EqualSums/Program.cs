using System;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var lastSum = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
            var maxDiff = 0;

            for (int i = 1; i < num; i++)
            {
                var firstNum = int.Parse(Console.ReadLine());
                var secondNum = int.Parse(Console.ReadLine());
                var sum = firstNum + secondNum;
                if (lastSum != sum)
                {
                    var currDiff = Math.Abs(lastSum - sum);
                    if (maxDiff < currDiff)
                    {
                        maxDiff = currDiff;
                    }
                }
                lastSum = sum;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value = {lastSum}");
            }
            else
            {
                Console.WriteLine($"No, maxDiff = {maxDiff}");
            }
        }
    }
}
