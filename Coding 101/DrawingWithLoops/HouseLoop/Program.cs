using System;

namespace HouseLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 0;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }

            var dashes = (n - stars) / 2;
            while (stars <= n)

            {
                for (int i = 0; i < dashes; i++)
                {
                    Console.Write("-");
                }
                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }
                for (int i = 0; i < dashes; i++)
                {
                    Console.Write("-");
                }

                Console.WriteLine();
                dashes--;
                stars += 2;
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n-2; j++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();

            }
        }
    }
}
