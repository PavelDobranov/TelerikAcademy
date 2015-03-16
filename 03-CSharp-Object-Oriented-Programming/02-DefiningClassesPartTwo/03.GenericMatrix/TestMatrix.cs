// Problem 8. Matrix
// Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

// Problem 9. Matrix indexer
// Implement an indexer this[row, col] to access the inner matrix cells.

// Problem 10. Matrix operations
// Implement the operators + and - (addition and subtraction of matrices of the same size) 
// and * for matrix multiplication.
// Throw an exception when the operation cannot be performed.
// Implement the true operator (check for non-zero elements).

namespace MatrixClass
{
    using System;

    class TestMatrix
    {
        static void Main()
        {
            int rows = 3;
            int cols = 3;
            int cellValue = 1;

            Matrix<int> firstMatrix = new Matrix<int>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    firstMatrix[row, col] = cellValue;
                    cellValue++;
                }
            }

            Matrix<int> secondMatrix = new Matrix<int>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    cellValue--;
                    secondMatrix[row, col] = cellValue;

                }
            }

            Console.WriteLine("First matrix:");
            Console.WriteLine(firstMatrix);

            Console.WriteLine("First matrix: {0}\n", firstMatrix ? "non-empty" : "empty");

            Console.WriteLine("Second matrix:");
            Console.WriteLine(secondMatrix);

            Console.WriteLine("First matrix + Second matrix: ");
            Console.WriteLine(firstMatrix + secondMatrix);

            Console.WriteLine("First matrix - Second matrix: ");
            Console.WriteLine(firstMatrix - secondMatrix);

            Console.WriteLine("First matrix * Second matrix: ");
            Console.WriteLine(firstMatrix * secondMatrix);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Columns; col++)
                {
                    firstMatrix[row, col] = 0;
                }
            }

            Console.WriteLine("First matrix: ");
            Console.WriteLine(firstMatrix);

            Console.WriteLine("First matrix: {0}\n", firstMatrix ? "non-empty" : "empty");
        }
    }
}