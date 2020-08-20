using System;

namespace Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("The number {0} is even", n);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number {0} is not even", n);
                    }
                }
                catch
                {
                    Console.WriteLine("The number is invalid!");
                }
            }
        }
    }
}
