using System;

namespace Test
{
    class Matrix
    {
        public static void Main()
        {
            int[,] matrix = {{1, 2, 3},{4, 5, 6}, {7, 8, 9},{10, 11, 12} };
            
            Console.WriteLine("Matrix:");
            for (int row = 0; row < matrix.GetLength(0); row++)//matrix.GetLength(0)=Identify the length of the row
            {
                for (int col = 0; col < matrix.GetLength(1); col++)//matrix.GetLength(1)=Identify the length of the column

                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
