using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimentions[0], dimentions[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] element = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < element.GetLength(0); col++)
                {
                    matrix[row, col] = element[col];
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    sum += matrix[r, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
