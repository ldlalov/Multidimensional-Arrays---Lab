using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] element = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < element.GetLength(0); col++)
                {
                    matrix[row, col] = element[col];
                }
            }
                int sum = 0;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                    sum += matrix[col, col];
            }
                Console.WriteLine(sum);

        }
    }
}
