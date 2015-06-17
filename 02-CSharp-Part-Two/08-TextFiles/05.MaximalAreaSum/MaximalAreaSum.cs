// Problem 5. Maximal area sum
// Write a program that reads a text file containing a square matrix of numbers.
// Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.

using System;
using System.IO;
using System.Collections.Generic;

class MaximalAreaSum
{
    const string PATH = @"..\..\TestFiles\";
    const string INPUT_FILE = PATH + "test.txt";
    static StreamReader reader;
    static StreamWriter writer;

    static void Main()
    {
        Console.Write("Enter Output File Name < filename.txt >: ");
        string fileName = Console.ReadLine();
        string outputFile = PATH + fileName;

        int[,] matrix = InitializeMatrix();

        int squareSize = 2;
        int maxSquareSum = int.MinValue;

        for (int row = 0; row <= matrix.GetLength(0) - squareSize; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - squareSize; col++)
            {

                int currentSquareSum = GetSquareSum(matrix, row, col, squareSize);

                if (currentSquareSum > maxSquareSum)
                {
                    maxSquareSum = currentSquareSum;
                }
            }
        }

        WriteToFile(maxSquareSum, outputFile);

        Console.WriteLine("New file with maximal sum created", outputFile);
        Console.WriteLine(outputFile);
    }

    static int[,] InitializeMatrix()
    {
        reader = new StreamReader(INPUT_FILE);

        int matrixSize = int.Parse(reader.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];

        for (int row = 0; row < matrixSize; row++)
        {
            string matrixRow = reader.ReadLine();
            char[] separator = { ' ' };

            string[] matrixRowArray = matrixRow.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < matrixSize; col++)
            {
                matrix[row, col] = int.Parse(matrixRowArray[col]);
            }
        }

        return matrix;
    }

    static int GetSquareSum(int[,] matrix, int startRow, int startCol, int squareSize)
    {
        int squareSum = 0;

        for (int row = startRow; row < startRow + squareSize; row++)
        {
            for (int col = startCol; col < startCol + squareSize; col++)
            {
                squareSum += matrix[row, col];
            }
        }

        return squareSum;
    }

    static void WriteToFile(int line, string file)
    {
        writer = new StreamWriter(file);

        using (writer)
        {
            writer.WriteLine(line);
        }
    }
}