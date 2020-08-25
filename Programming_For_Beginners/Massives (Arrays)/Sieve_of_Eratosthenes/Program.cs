using System;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var primes= new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }
            for (int p = 2; p <= n; p++)
            {
                if (primes[p]) { FillPrimes(primes, p); }

            }
            
        }

        static void FillPrimes(bool[] primes, int stat)
        {
            for (int i = 2 * stat; i <= primes.Length; i += stat)
            {
                primes[i] = false;
                Console.WriteLine($"Not Prime {i}");
            }

        }
    }
}
