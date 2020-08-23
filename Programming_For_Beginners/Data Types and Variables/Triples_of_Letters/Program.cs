using System;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (char letter = 'a'; letter < 'a' + n; letter++)
            {
                for (char letter2 = 'a'; letter2 < 'a' + n; letter2++)
                {
                    for (char letter3 = 'a'; letter3 < 'a' + n; letter3++)
                    {
                        Console.WriteLine($"{letter}{letter2}{letter3}");
                    }
                }
            }
        }
    }
}
