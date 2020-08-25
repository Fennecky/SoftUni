using System;

namespace Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a day!: ");
            string[] days = { "Monday", "Thusday", "Wednsday", "Thursday", "Friday", "Satruday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            
            if (day >= 0 && day <= 7)
            {
                Console.Write("The day is: ");
                Console.Write(days[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
