using System;
using System.Linq;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("First = {0}", nums.First());
            Console.WriteLine("Last = {0}", nums.Last());
            Console.WriteLine("Avarage = {0}", nums.Average());
        }
    }
}
