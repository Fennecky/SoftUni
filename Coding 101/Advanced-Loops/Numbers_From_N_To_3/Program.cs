using System;

namespace Numbers_From_N_To_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
                Console.Write("The number is currently: ");
            }
            Console.WriteLine(n);
        }
    }
}
