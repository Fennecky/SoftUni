using System;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var primes= new bool[n + 1];
            primes[0] = primes[1] = false;


            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }
            for (int prime = 2; prime <= n; prime++)
            {
                if (primes[prime]) 
                { 
                    ChecksForPrime(primes, prime); 
                }
            }
            
        }

        static void ChecksForPrime(bool[] primes, int prime)
        {
            for (int i = 2 * prime; i <= primes.Length; i += prime)
            {
                primes[i + 2] = false;
                Console.WriteLine($"Not Prime {i}");
            }

        }
    }
}
