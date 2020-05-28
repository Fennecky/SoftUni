using System;

namespace Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var seconds = num1 + num2 + num3;
            var minutes = seconds / 60;
            var remainingSeconds = seconds % 60;
            Console.WriteLine($"{minutes}:{remainingSeconds:D2}");
        }
    }
}
