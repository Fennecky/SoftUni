using System;

namespace Numbers_From_1_To_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var power = Math.Pow(2, n);
            for (int i = 1; i <= power; i*=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
