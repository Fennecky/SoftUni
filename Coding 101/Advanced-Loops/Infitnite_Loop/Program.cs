using System;

namespace Infitnite_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number!: ");
            var n = 0;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n < 10)
                    {
                        Console.WriteLine("Good! The number {0} is between 1 and 10!", n);
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("The number {0} is not between 1 and 10, try again: ", n);
                }
            }   
        }
    }
}
