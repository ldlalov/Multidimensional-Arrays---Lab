using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray() ;
            int[,] matrix = new int[dimentions[0],dimentions[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] element = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < element.GetLength(0); col++)
                {
                    matrix[row,col] = element[col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
