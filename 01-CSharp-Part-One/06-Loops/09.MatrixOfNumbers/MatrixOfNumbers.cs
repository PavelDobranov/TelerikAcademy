// Problem 9. Matrix of Numbers
// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
// and prints a matrix like in the examples below. Use two nested loops.

using System;

public class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter number [n] [1 ≤ n ≤ 20]: ");
        int numberN = int.Parse(Console.ReadLine());

        if (numberN >= 1 && numberN <= 20)
        {
            PrintMatrixOfNumbers(numberN);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }

    private static void PrintMatrixOfNumbers(int numberN)
    {
        int padding = 3;

        for (int row = 1; row <= numberN; row++)
        {
            for (int col = row; col < numberN + row; col++)
            {
                Console.Write("{0} ", col.ToString().PadLeft(padding, ' '));
            }

            Console.WriteLine();
        }
    }
}