using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of numbers you want to compare: ");
            var number = int.Parse(Console.ReadLine());
            var firstSum = 0;

            for (int i = 0; i < number; i++)
            {
                var x = int.Parse(Console.ReadLine());
                firstSum += x;
            }

            var secondSum = 0;
            for (int i = 0; i < number; i++)
            {
                var y = int.Parse(Console.ReadLine());
                secondSum += y;
            }

            if (firstSum == secondSum)
            {
                Console.Write("Yes, ");
                Console.Write($"Sum = {firstSum}");
            }
            else
            {
                var diff = Math.Abs(firstSum - secondSum);
                Console.Write("No, the diff is: ");
                Console.Write(diff);
            }
        }   
    }
}
