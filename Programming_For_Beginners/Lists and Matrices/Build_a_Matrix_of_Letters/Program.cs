using System;

namespace Build_a_Matrix_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new char[4, 7];
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);

            char letters = 'A';

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = letters;
                    letters++;
                    if (letters > 'Z')
                    {
                        letters = 'A';
                    }
                }

            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
