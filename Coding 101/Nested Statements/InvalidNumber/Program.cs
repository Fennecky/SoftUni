using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number here: ");
            var number = int.Parse(Console.ReadLine());
            var inRange = (number >= 100 && number <= 200 || number == 0);

            if (!inRange)
            {
                Console.WriteLine($"{number} is invalid");
            }
            else
            {
                Console.WriteLine($"{number} is a valid number!");
            }
        }
    }
}
