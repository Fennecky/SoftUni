using System;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a century: ");
            int centuries = int.Parse(Console.ReadLine());
            long years = (long) centuries * 100;
            long days = (long) (years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"Centures = {centuries}; years = {years} days = {days} hours = {hours} minutes = {minutes} seconds = {seconds} milliseconds = {milliseconds} microseconds = {microseconds} nanoseconds = {nanoseconds}");
        }
    }
}
