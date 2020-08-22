using System;

namespace NestedForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int star = 0; star < n; star++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int tick = 0; tick < n; tick++)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
