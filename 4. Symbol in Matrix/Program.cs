using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] element = Console.ReadLine().ToCharArray();
                for (int col = 0; col < element.GetLength(0); col++)
                {
                    matrix[row, col] = element[col].ToString();
                }
            }
            string symbol = Console.ReadLine();
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c].ToString() == symbol)
                    {
                        Console.WriteLine($"({r}, {c})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix ");
        }
    }
}
