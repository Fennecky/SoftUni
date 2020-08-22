using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number!: ");
            var n = int.Parse(Console.ReadLine());
            var f0 = 1;
            var f1 = 1;
            for (int i = 1; i <= n; i++)
            {
                var sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }
            Console.WriteLine("The number is {0}!", f1);
        }
    }
}
