// Problem 16.* Print Long Sequence
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
// You might need to learn how to use loops in C# (search in Internet).

using System;

public class PrintSequence
{
    static void Main()
    {
        int numbersCount = 1000;
        int startNumber = 2;

        for (int number = startNumber; number < numbersCount + startNumber; number++)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
            else
            {
                Console.Write(-number + " ");
            }
        }

        Console.WriteLine();
    }
}