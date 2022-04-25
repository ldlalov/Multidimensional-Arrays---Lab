using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimentions[0], dimentions[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] element = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < element.GetLength(0); col++)
                {
                    matrix[row, col] = element[col];
                }
            }
            int sum = 0;
            int[] square1 = new int[2];
            int[] square2 = new int[2];
            for (int r = 0; r < matrix.GetLength(0)-1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1)-1; c++)
                {
                    int tempSum = matrix[r, c] + matrix[r,c+1] + matrix[r+1,c] + matrix[r+1,c+1];
                    if (tempSum>sum)
                    {
                        sum = tempSum;
                        square1[0] = matrix[r, c];
                        square1[1] = matrix[r, c+1];
                        square2[0] = matrix[r+1, c];
                        square2[1] = matrix[r+1, c+1];
                    }
                }
            }
            Console.WriteLine(String.Join(' ', square1));
            Console.WriteLine(String.Join(' ', square2));
            Console.WriteLine(sum);
        }
    }
}
