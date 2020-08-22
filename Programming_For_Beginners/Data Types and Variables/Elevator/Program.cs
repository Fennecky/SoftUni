using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int course = (int) Math.Ceiling( (double) p / n);
            Console.WriteLine(course);
        }
    }
}
