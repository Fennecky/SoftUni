using System;

namespace LoopPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 10 == 7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.Write("The ABC's are: ");
            //for (var letter = 'a'; letter <= 'z'; letter++)
            //{
            //    Console.Write(" " + letter);
            //}

            Console.WriteLine("Please enter a number = ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please enter {n} numbers in a row: ");
            var s = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                s = s + num;
            }
            Console.WriteLine($"The sum is {s}");

        }
    }
}
