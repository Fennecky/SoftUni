using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Checking your number...");
            bool prime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("The number {0} is prime", n);
            }
            else
            {
                Console.WriteLine("The number {0} is not prime", n);
            }
        }
    }
}
