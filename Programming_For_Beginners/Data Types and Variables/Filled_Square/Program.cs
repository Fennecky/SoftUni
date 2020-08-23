using System;

namespace Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            topRow(n);
            middleRow(n);
            bottomRow(n);

        }

        static int topRow(int n)
        {
            Console.WriteLine(new string ('-', 2 * n));
            return 0;
        }

        static int middleRow(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(@"/\");
            }
            Console.Write("-");
            Console.WriteLine();
            return 0;
        }
        static int bottomRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
            return 0;
        }
    }
}
