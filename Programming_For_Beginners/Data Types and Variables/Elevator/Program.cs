using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many people want to get in the elivator?: ");
            int p = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine($"Only {l} number of people can get on at one time!");

            int course = (int) Math.Ceiling( (double) p / l);
            Console.WriteLine($"It would take {course} courses to transport {p} people!");
        }
    }
}
