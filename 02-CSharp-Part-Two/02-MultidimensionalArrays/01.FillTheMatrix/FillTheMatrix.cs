// Problem 1. Fill the matrix
// Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;
class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter matrix size: ");
        int matrixSize = int.Parse(Console.ReadLine());

        Console.WriteLine("\na)");
        PrintVerticalMatrix(matrixSize);

        Console.WriteLine("\nb)");
        PrintZigZagMatrix(matrixSize);

        Console.WriteLine("\nc)");
        PrintDiagonalMatrix(matrixSize);

        Console.WriteLine("\nd)");
        PrintSpiralMatrix(matrixSize);
    }

    static void PrintVerticalMatrix(int matrixSize)
    {
        int[,] matrix = new int[matrixSize, matrixSize];
        int cellValue = 1;

        for (int col = 0; col < matrixSize; col++)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                matrix[row, col] = cellValue;
                cellValue++;
            }
        }

        PrintMatrix(matrix);
    }
    
    static void PrintZigZagMatrix(int matrixSize)
    {
        int[,] matrix = new int[matrixSize, matrixSize];
        int cellValue = 0;
        int direction = 1;
        int row = 0;

        for (int col = 0; col < matrixSize; col++)
        {
            while (true)
            {
                cellValue++;

                matrix[row, col] = cellValue;

                if (cellValue % matrixSize == 0)
                {
                    break;
                }

                row += direction;
            }

            direction *= -1;
        }

        PrintMatrix(matrix);
    }
    
    static void PrintDiagonalMatrix(int matrixSize)
    {
        int[,] matrix = new int[matrixSize, matrixSize];
        int startRow = matrixSize - 1;
        int startCol = 0;
        int cellValue = 0;

        while (cellValue != matrixSize * matrixSize)
        {
            int row = startRow;
            int col = startCol;

            while (true)
            {
                cellValue++;
                matrix[row, col] = cellValue;

                if (col + 1 >= matrixSize)
                {
                    startCol++;
                    break;
                }

                if (row + 1 >= matrixSize)
                {
                    startRow--;
                    break;
                }

                row++;
                col++;
            }
        }

        PrintMatrix(matrix);
    }
    
    static void PrintSpiralMatrix(int matrixSize)
    {
        int[,] matrix = new int[matrixSize, matrixSize];
        int row = 0;
        int col = 0;
        int cellValue = 1;
        string direction = "down";

        while (cellValue != matrixSize * matrixSize)
        {
            matrix[row, col] = cellValue;
            cellValue++;

            if (direction == "down" && (row + 1 >= matrixSize || matrix[row + 1, col] != 0))
            {
                direction = "right";
            }

            if (direction == "right" && (col + 1 >= matrixSize || matrix[row, col + 1] != 0))
            {
                direction = "up";
            }

            if (direction == "up" && (row - 1 < 0 || matrix[row - 1, col] != 0))
            {
                direction = "left";
            }

            if (direction == "left" && (col - 1 < 0 || matrix[row, col - 1] != 0))
            {
                direction = "down";
            }

            if (direction == "down")
            {
                row++;
            }

            if (direction == "right")
            {
                col++;
            }

            if (direction == "up")
            {
                row--;
            }

            if (direction == "left")
            {
                col--;
            }
        }

        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}