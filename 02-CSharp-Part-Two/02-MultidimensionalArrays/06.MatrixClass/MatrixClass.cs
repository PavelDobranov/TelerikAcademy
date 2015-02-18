// Problem 6.* Matrix class
// Write a class Matrix, to hold a matrix of integers. Overload the operators for adding,
// subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;

namespace MatrixClass
{
    class MatrixClass
    {
        static void Main()
        {
            Matrix firstMatrix = new Matrix(new int[,] { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } });
            Matrix secondMatrix = new Matrix(new int[,] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } });

            Console.WriteLine("First matrix:");
            Console.WriteLine(firstMatrix);

            Console.WriteLine("Second matrix:");
            Console.WriteLine(secondMatrix);

            Console.WriteLine("Result after addition:");
            Console.WriteLine(firstMatrix - secondMatrix);

            Console.WriteLine("Result after substraction:");
            Console.WriteLine(firstMatrix - secondMatrix);

            Console.WriteLine("Result after multiplication:");
            Console.WriteLine(firstMatrix * secondMatrix);
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
}
