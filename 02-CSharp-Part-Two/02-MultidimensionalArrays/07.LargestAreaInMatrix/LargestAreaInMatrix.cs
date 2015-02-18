// Problem 7.* Largest area in matrix
// Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.{

using System;

class LargestAreaInMatrix
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

        bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        int restult = GetLargetsArea(matrix, visited);
        
        Console.WriteLine("Result: {0}", restult);
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

    static int GetLargetsArea(int[,] matrix, bool[,] visited)
    {
        int largestAreaCount = 0;
        int currentCount = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (!visited[row, col])
                {
                    currentCount = CountArea(matrix, row, col, visited, 0);

                    if (currentCount > largestAreaCount)
                    {
                        largestAreaCount = currentCount;
                    }
                }
            }
        }

        return largestAreaCount;
    }

    static int CountArea(int[,] matrix, int row, int col, bool[,] visited, int count)
    {
        count++;
        visited[row, col] = true;

        if (col - 1 >= 0 && matrix[row, col - 1] == matrix[row, col] && !visited[row, col - 1])
        {
            count = CountArea(matrix, row, col - 1, visited, count);
        }

        if (row - 1 >= 0 && matrix[row - 1, col] == matrix[row, col] && !visited[row - 1, col])
        {
            count = CountArea(matrix, row - 1, col, visited, count);
        }

        if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == matrix[row, col] && !visited[row, col + 1])
        {
            count = CountArea(matrix, row, col + 1, visited, count);
        }

        if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == matrix[row, col] && !visited[row + 1, col])
        {
            count = CountArea(matrix, row + 1, col, visited, count);
        }

        return count;
    }
}