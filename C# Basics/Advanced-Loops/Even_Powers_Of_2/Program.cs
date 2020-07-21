using System;

namespace Even_Powers_Of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i < Math.Pow(4, n); i*=4)
            {
                Console.WriteLine(i);
            }
        }
    }
}
