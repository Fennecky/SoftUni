using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
