using System;

namespace Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = -1;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n >= 1 && n <=100)
                    {
                        Console.WriteLine("Thank you! the number is: {0} ", n);
                        break;
                    }
                    Console.WriteLine("Invalid number! Try again...");
                }
                catch
                {
                    Console.WriteLine("This is not a number!");
                }
            }
        }
    }
}
