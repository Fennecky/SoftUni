using System;
using System.Linq;

namespace Change_Forbidden_Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');

            foreach (var word in words)
            {
                str = str.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(str);
        }
    }
}
