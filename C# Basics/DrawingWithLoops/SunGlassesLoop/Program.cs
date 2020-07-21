using System;

namespace SunGlassesLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var col = (n * 2) - 2;
            for (int row = 1; row <= n*2; row++)
            {
                Console.Write("*");
            }

            for (int row = 0; row < n; row++)
            {
                Console.Write(" ");
            }

            for (int row = 1; row <= n*2; row++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            var rimRow = (n / 2);
            if (n % 2 == 0)
            {
                rimRow--;
            }
            for (int i = 1; i <= n - 2; i++) 
            {
                Console.Write("*");
                for (int row = 0; row < col; row++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                for (int row = 0; row < n; row++)
                {
                    if (i == rimRow)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int row = 0; row < col; row++)
                {
                    Console.Write("/");
                }
                Console.WriteLine("*");
            }

            for (int row = 1; row <= n*2; row++)
            {
                Console.Write("*");
            }

            for (int row = 0; row < n; row++)
            {
                Console.Write(" ");
            }

            for (int row = 1; row <= n*2; row++)
            {
                Console.Write("*");
            }


        }
    }
}
