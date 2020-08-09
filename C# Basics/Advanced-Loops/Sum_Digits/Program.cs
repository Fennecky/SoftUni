using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;

            while (number > 0)
            {
                var digit = (number % 10);
                sum = sum + digit;
                number = (number / 10);
            }
            Console.WriteLine(sum);
        }
    }
}
