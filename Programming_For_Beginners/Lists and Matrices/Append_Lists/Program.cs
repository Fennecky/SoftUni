using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();

            for (int i = lists.Count - 1; i >= 0; i--)
            {
                var list = lists[i].Split(' ');
                foreach (var item in list)
                {
                    if (item != "")
                    {
                        result.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
