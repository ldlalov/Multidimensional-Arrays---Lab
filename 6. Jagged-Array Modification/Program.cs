using System;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[int.Parse(Console.ReadLine())][];
            for (int row = 0; row < jagged.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split(' ');
                jagged[row] = new int[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(inputNumbers[col]);
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmd = input.Split();
                switch (cmd[0])
                {
                    case "Add":
                        int row = int.Parse(cmd[1]);
                        int column = int.Parse(cmd[2]);
                        int value = int.Parse(cmd[3]);
                        if (0 <= row && row < jagged.Length && 0 <= column && column < jagged.Length)
                        {
                            jagged[row][column] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        row = int.Parse(cmd[1]);
                        column = int.Parse(cmd[2]);
                        value = int.Parse(cmd[3]);
                        if (0 <= row && row < jagged.Length && 0 <= column && column < jagged.Length)
                        {
                            jagged[row][column] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                }
            }
            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
