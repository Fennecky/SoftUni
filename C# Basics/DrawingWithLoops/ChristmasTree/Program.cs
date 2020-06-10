using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var spaces = n;
            for (int i = 0; i < spaces + 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            for (int row = 1; row <= n; row++)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < row; i++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int i = 0; i < row; i++)
                {
                    Console.Write("*");
                }
                spaces--;
                Console.WriteLine();

            }

        }
    }
}
