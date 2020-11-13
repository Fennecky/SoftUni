using System;
using System.Collections.Generic;

namespace Check_Word_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            var count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
