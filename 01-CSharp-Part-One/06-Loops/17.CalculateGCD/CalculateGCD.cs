// Problem 17.* Calculate GCD
// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
// Use the Euclidean algorithm (find it in Internet).

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD(a,b): {0}", GetGreatestCommonDivisor(firstNumber, secondNumber));
    }

    static int GetGreatestCommonDivisor(int firstNumber, int secondNumber)
    {
        int remainder;

        while (secondNumber > 0)
        {
            remainder = secondNumber;
            secondNumber = firstNumber % secondNumber;
            firstNumber = remainder;
        }

        return firstNumber;
    }
}