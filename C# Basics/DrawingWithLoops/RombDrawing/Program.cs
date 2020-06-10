using System;

namespace RombDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var spaces = n - 1;
            for (int row = 1; row <= n; row++)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < row; i++)
                {
                    Console.Write("* ");
                }
                spaces--;
                Console.WriteLine();
            }

            var reverseSpaces = 1;
            for (int row = n-1; row > 0; row--)
            {
                for (int i = 0; i < reverseSpaces; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < row; i++)
                {
                    Console.Write("* ");
                }
                reverseSpaces++;
                Console.WriteLine();
            }
        }
    }
}
