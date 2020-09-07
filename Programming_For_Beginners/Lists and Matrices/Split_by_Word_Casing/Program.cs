using System;
using System.Collections.Generic;
using System.Linq;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var splitter = new char[] { '.', ',', ';', '!', ' ', '\"', '\'' };
            var str = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();

            foreach (var statment in str)
            {
                bool lowerLetter = false;
                bool upperLetter = false;
                foreach (var letter in statment)
                {
                    if (letter >= 'a' && letter <= 'z')
                    {
                        lowerLetter = true;
                    }
                    else if (letter >= 'A' && letter <= 'Z')
                    {
                        upperLetter = true;
                    }
                    else
                    {
                        lowerLetter = true;
                        upperLetter = true;
                    }
                }
                if (lowerLetter && upperLetter)
                {
                    mixedCase.Add(statment);
                }
                else if (lowerLetter == true)
                {
                    lowerCase.Add(statment);
                }
                else if (upperLetter == true)
                {
                    upperCase.Add(statment);
                }
                
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
