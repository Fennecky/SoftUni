using System;

namespace Random_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine().Split();
            Random random = new Random();

            for (int i = 0; i < userInput.Length; i++)
            {
                var firstIndex = random.Next(0, userInput.Length);
                var secondIndex = random.Next(0, userInput.Length);

                var firstOld = userInput[firstIndex];
                userInput[firstIndex] = userInput[secondIndex];
                userInput[secondIndex] = firstOld;
                
            }
            Console.WriteLine(string.Join(Environment.NewLine, userInput));
        }
    }
}
