using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userInput = GetUserInput();
            List<int> result = new List<int>();

            foreach (var num in userInput)
            {
                if (num >= 0)
                {
                    result.Add(num);
                }
            }
            result.Reverse();
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
        private static List<int> GetUserInput()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        }
    }
}
