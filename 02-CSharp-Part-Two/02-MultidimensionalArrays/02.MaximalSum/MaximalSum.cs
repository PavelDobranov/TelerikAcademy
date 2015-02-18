// Problem 2. Maximal sum
// Write a program that reads a rectangular matrix of size N x M and finds in it
// the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        // **Note for input see Tests.txt

        Console.Write("Enter matrix rows: ");
        int rowsCount = int.Parse(Console.ReadLine());

        Console.Write("Enter matrix columns: ");
        int colsCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter matrix rows (separated by ',')");
        int[,] matrix = ParseMatrixOfIntegers(rowsCount, colsCount);

        int squareSize = 3;
        int maxSum = int.MinValue;
        int maxSquareRow = 0;
        int maxSquareCol = 0;

        for (int row = 0; row <= matrix.GetLength(0) - squareSize; row++)
        {
            int currentSum = 0;

            for (int col = 0; col <= matrix.GetLength(1) - squareSize; col++)
            {
                currentSum = GetSubMatrixSum(matrix, squareSize, row, col);

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSquareRow = row;
                    maxSquareCol = col;
                }
            }
        }

        PrintSubMatrix(matrix, squareSize, maxSquareRow, maxSquareCol);
        Console.WriteLine("Maximal sum: {0}", maxSum);
    }

    static int[,] ParseMatrixOfIntegers(int rowsCount, int colsCount)
    {
        int[,] matrix = new int[rowsCount, colsCount];

        for (int row = 0; row < rowsCount; row++)
        {
            Console.Write("row[{0}]: ", row);
            string matrixRow = Console.ReadLine();
            string[] separators = { " ", "," };
            string[] matrixRowArray = matrixRow.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < colsCount; col++)
            {
                matrix[row, col] = int.Parse(matrixRowArray[col]);
            }
        }

        return matrix;
    }

    static int GetSubMatrixSum(int[,] matrix, int squareSize, int startRow, int startCol)
    {
        int sum = 0;

        for (int row = startRow; row < startRow + squareSize; row++)
        {
            for (int col = startCol; col < startCol + squareSize; col++)
            {
                sum += matrix[row, col];
            }
        }

        return sum;
    }

    static void PrintSubMatrix(int[,] matrix, int squareSize, int startRow, int startCol)
    {
        for (int row = startRow; row < startRow + squareSize; row++)
        {
            for (int col = startCol; col < startCol + squareSize; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}