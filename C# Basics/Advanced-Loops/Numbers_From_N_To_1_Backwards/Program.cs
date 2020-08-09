using System;

namespace Numbers_From_N_To_1_Backwards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            var num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                Console.Write("The number is: ");
                Console.WriteLine(i);
            }
            Console.WriteLine("The number is: 0!");
        }
    }
}
