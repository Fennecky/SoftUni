﻿using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i = i * 2 + 1)
            {
                Console.WriteLine(i);
               
            }
        }
    }
}
