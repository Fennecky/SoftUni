using System;

namespace Numbers_From_1_To_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Math.Pow(2, n); i*=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
