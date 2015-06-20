// Problem 11.* Numbers in Interval Dividable by Given Number
// Write a program that reads two positive integer numbers and prints how many numbers p
// exist between them such that the reminder of the division by 5 is 0.

using System;

public class NumbersDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int startRange = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int endRange = int.Parse(Console.ReadLine());

        int divider = 5;

        int result = 0;

        if (startRange % divider == 0 && endRange % divider == 0)
        {
            result++;
        }

        startRange /= divider;
        endRange /= divider;

        result += Math.Abs(endRange - startRange);

        Console.WriteLine("Result: p = {0}", result);
    }
}