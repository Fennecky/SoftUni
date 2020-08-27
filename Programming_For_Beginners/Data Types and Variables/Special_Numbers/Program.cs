using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int digits = sumOfDigits(num);
                bool specialNumbers = (digits == 5) || (digits == 7) || (digits == 11);
                Console.WriteLine($"{num} -> {specialNumbers}");
            }
        }

        static int sumOfDigits(int numbers)
        {
            int digits = 0;
            while (digits > 0)
            {
                digits += numbers % 10;
                digits /= 10;
            }
            return numbers;
        }
    }
}
