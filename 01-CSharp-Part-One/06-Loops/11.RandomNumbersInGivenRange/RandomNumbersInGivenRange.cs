// Problem 11. Random Numbers in Given Range
// Write a program that enters 3 integers n, min and max (min != max) and prints
// n random numbers in the range

using System;

public class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter number [n]: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("Enter minimal value: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Enter maximal value: ");
        int max = int.Parse(Console.ReadLine());

        Random randomNumberGenerator = new Random();

        for (int number = 0; number < numberN; number++)
        {
            Console.Write("{0} ", randomNumberGenerator.Next(min, max + 1));
        }

        Console.WriteLine();
    }
}