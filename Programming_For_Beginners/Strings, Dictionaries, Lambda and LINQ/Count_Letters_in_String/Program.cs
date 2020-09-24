using System;
using System.Linq;

namespace Count_Letters_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToLower();
            var count = new int[str.Max() + 1];

            foreach (var letter in str)
            {
                count[letter]++;
            }

            for (char i = (char) 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", i, count[i]);
                }
            }
        }
    }
}
