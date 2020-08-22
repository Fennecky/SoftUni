using System;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal f1 = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= f1; i++)
            {
                decimal f2 = decimal.Parse(Console.ReadLine());
                sum += f2;
            }
            Console.WriteLine(sum);
        }
    }
}
