using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lastNums = nums[0];
            int currentSequence = 1;
            int maxSequenceNum = 0;
            long maxSequence = 0;

            for (int i = 1; i < nums.Count; i++)
            {
                if (lastNums == nums[i])
                {
                    currentSequence++;
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        maxSequenceNum = nums[i];
                    }
                }
                else
                {
                    currentSequence = 1;
                    lastNums = nums[i];
                }
            }

            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(maxSequenceNum + " ");
            }
        }
    }
}
