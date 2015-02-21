// Problem 19.** Spiral Matrix
// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints
// a matrix holding the numbers from 1 to n*n in the form of square spiral.

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter number [n]: ");
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];

        FillSpiralMatrix(matrix, matrixSize);
        PrintSpiralMatrix(matrix);
    }

    static void FillSpiralMatrix(int[,] matrix, int matrixSize)
    {
        int startValue = 1;
        int positionRow = 0;
        int positionCol = 0;
        string direction = "right";

        for (int value = startValue; value <= matrixSize * matrixSize; value++)
        {
            matrix[positionRow, positionCol] = value;

            if (direction == "right" && (positionCol + 1 >= matrixSize || matrix[positionRow, positionCol + 1] != 0))
            {
                direction = "down";
            }

            if (direction == "down" && (positionRow + 1 >= matrixSize || matrix[positionRow + 1, positionCol] != 0))
            {
                direction = "left";
            }

            if (direction == "left" && (positionCol - 1 < 0 || matrix[positionRow, positionCol - 1] != 0))
            {
                direction = "up";
            }

            if (direction == "up" && (positionRow - 1 < 0 || matrix[positionRow - 1, positionCol] != 0))
            {
                direction = "right";
            }

            switch (direction)
            {
                case "right": positionCol++; break;
                case "left": positionCol--; break;
                case "up": positionRow--; break;
                case "down": positionRow++; break;
            }
        }
    }

    static void PrintSpiralMatrix(int[,] matrix)
    {
        int padding = 3;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col].ToString().PadRight(padding, ' '));
            }

            Console.WriteLine();
        }
    }
}