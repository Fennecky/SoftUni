using System;

namespace Count_Occurrences_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToLower();
            var occurence = Console.ReadLine().ToLower();
            int position = 0;
            int count = 0;
            while (true)
            {
                position = str.IndexOf(occurence, position);
                if (position == -1)
                {
                    break;
                }
                position += 1;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
