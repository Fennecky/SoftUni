using System;
using System.Linq;

namespace Print_a_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine(@"/----------------------\");
            foreach (var num in nums)
            {
                Console.WriteLine(@"|{0,21:f2} |", num);
            }
            Console.WriteLine(@"|----------------------|");
            Console.WriteLine(@"|Total:{0,15:f2} |", nums.Sum());
            Console.WriteLine(@"\----------------------/");
        }
    }
}
