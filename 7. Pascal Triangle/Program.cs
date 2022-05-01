using System;
using System.Data.Common;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[][] triangle = new long[int.Parse(Console.ReadLine())][];
            int currentWidth = 1;
            for (int row = 0; row < triangle.Length; row++)
            {
                triangle[row] = new long[currentWidth];
                long[] currentRow = triangle[row];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                if (currentRow.Length > 2)
                {
                    for (int i = 1; i < currentRow.Length - 1; i++)
                    {
                        long[] previousRow = triangle[row - 1];
                        long prevoiousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = prevoiousRowSum;
                    }
                }
                // TODO: Print triangle
                currentWidth++;
            }
                foreach (long[] row in triangle)
                    Console.WriteLine(string.Join(" ", row));
        }
    }
}
