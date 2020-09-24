using System;

namespace Print_String_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToLower();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"str[{i}] -> {str[i]}");
            }
        }
    }
}
