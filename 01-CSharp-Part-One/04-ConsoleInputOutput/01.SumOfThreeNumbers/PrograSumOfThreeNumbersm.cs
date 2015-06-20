// Problem 1. Sum of 3 Numbers
// Write a program that reads 3 real numbers from the console and prints their sum.

using System;

public class SumOfThreeNumbers
{
    static void Main()
    {
        double sum = 0;

        int numbersCount = 3;

        for (int i = 0; i < numbersCount; i++)
        {
            Console.Write("Enter number [{0}]: ", (char)('a' + i));
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine("a + b + c = {0}", sum);
    }
}