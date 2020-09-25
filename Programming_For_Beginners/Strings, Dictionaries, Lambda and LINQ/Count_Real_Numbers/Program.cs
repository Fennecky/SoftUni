using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var count = new SortedDictionary<double,int>();

            foreach (var num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }

            foreach (var pair in count)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }

        }
    }
}
