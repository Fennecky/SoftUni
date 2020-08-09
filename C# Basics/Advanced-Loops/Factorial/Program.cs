using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
