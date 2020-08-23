using System;

namespace Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double sum = Math.PI * r * r;

            Console.WriteLine($"{sum:f12}");

        }
    }
}
