// Problem 3. Sequence n matrix
// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
// of several neighbour elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class SequenceInMatrix
{
    static void Main()
    {
        // **Note for input see Tests.txt

        Console.Write("Enter matrix rows: ");
        int rowsCount = int.Parse(Console.ReadLine());

        Console.Write("Enter matrix columns: ");
        int colsCount = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter matrix rows (separated by ',')");
        string[,] matrix = ParseMatrixOfStrings(rowsCount, colsCount);

        int maxElementCount = int.MinValue;
        string maxElement = String.Empty;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (HorizontalCount(matrix, row, col) > maxElementCount)
                {
                    maxElementCount = HorizontalCount(matrix, row, col);
                    maxElement = matrix[row, col];
                }

                if (VerticalCount(matrix, row, col) > maxElementCount)
                {
                    maxElementCount = VerticalCount(matrix, row, col);
                    maxElement = matrix[row, col];
                }

                if (DiagonalCountTLBR(matrix, row, col) > maxElementCount)
                {
                    maxElementCount = DiagonalCountTLBR(matrix, row, col);
                    maxElement = matrix[row, col];
                }

                if (DiagonalCountTRBL(matrix, row, col) > maxElementCount)
                {
                    maxElementCount = DiagonalCountTRBL(matrix, row, col);
                    maxElement = matrix[row, col];
                }
            }
        }

        Console.Write("Result: ");

        for (int count = 0; count < maxElementCount; count++)
        {
            Console.Write("{0} ", maxElement);
        }

        Console.WriteLine();
    }

    static string[,] ParseMatrixOfStrings(int rowsCount, int colsCount)
    {
        string[,] matrix = new string[rowsCount, colsCount];

        for (int row = 0; row < rowsCount; row++)
        {
            Console.Write("row[{0}]: ", row);
            string matrixRow = Console.ReadLine();
            string[] matrixRowArray = matrixRow.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < colsCount; col++)
            {
                matrix[row, col] = matrixRowArray[col];
            }
        }

        return matrix;
    }

    // horizontal count (left to right)
    static int HorizontalCount(string[,] matrix, int row, int col)
    {
        int counter = 1;

        while (col < matrix.GetLength(1) - 1 && matrix[row, col] == matrix[row, col + 1])
        {
            counter++;
            col++;
        }

        return counter;
    }

    // vertical count (top to bottom)
    static int VerticalCount(string[,] matrix, int row, int col)
    {
        int counter = 1;

        while (row < matrix.GetLength(0) - 1 && matrix[row, col] == matrix[row + 1, col])
        {
            counter++;
            row++;
        }

        return counter;
    }

    // diagonal count (top-left to bottom-right)
    static int DiagonalCountTLBR(string[,] matrix, int row, int col)
    {
        int counter = 1;

        while (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 && matrix[row, col] == matrix[row + 1, col + 1])
        {
            counter++;
            row++;
            col++;
        }

        return counter;
    }

    // diagonal count (top-right to bottom-left)
    static int DiagonalCountTRBL(string[,] matrix, int row, int col)
    {
        int counter = 1;

        while (row > 0 && col > 0 && matrix[row, col] == matrix[row - 1, col - 1])
        {
            counter++;
            row--;
            col--;
        }

        return counter;
    }
}