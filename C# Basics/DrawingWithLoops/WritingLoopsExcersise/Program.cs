using System;

namespace WritingLoopsExcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            // N by N stars
            //var n = int.Parse(Console.ReadLine());
            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Square N Stars
            //var n = int.Parse(Console.ReadLine());
            //for (int row = 0; row < n; row++)
            //{
            //    Console.Write('*');
            //    for (int col = 0; col < n; col++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}

            //var n = int.Parse(Console.ReadLine());
            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col <= row; col++)
            //    {
            //        Console.Write("$ ");
            //    }
            //    Console.WriteLine();
            //}

            var n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int col = 0; col < n - 2; col++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("| ");
                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("| ");
            }

            Console.Write("+ ");
            for (int col = 0; col < n - 2; col++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }

    }
}
