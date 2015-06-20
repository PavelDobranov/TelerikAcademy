// Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
// Write a program that, for a given two integer numbers n and x,
// calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Numerics;

public class FactorialSum
{
    static void Main()
    {
        Console.Write("Enter number [n]: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("Enter number [x]: ");
        int numberX = int.Parse(Console.ReadLine());

        int xAtPowerN = 1;
        BigInteger factorial = 1;
        BigInteger sum = 1;

        for (int i = 1; i <= numberN; i++)
        {
            factorial *= i;
            xAtPowerN *= numberX;
            sum += (factorial / xAtPowerN);
        }

        Console.WriteLine("S = {0:F5}", sum);
    }
}