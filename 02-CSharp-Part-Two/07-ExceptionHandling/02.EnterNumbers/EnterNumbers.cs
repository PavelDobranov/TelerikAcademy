// Problem 2. Enter numbers
// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;

class EnterNumbers
{
    static int start = 1;
    static int end = 100;

    static void Main()
    {
        int[] numbersCollector = new int[10];

        try
        {
            for (int i = 0; i < numbersCollector.Length; i++)
            {
                int number = GetNumber(start, end);
                numbersCollector[i] = number;
                start = number;
            }

            Console.WriteLine("Entered Numbers:\n[start-1] < {0} < [100-end]", string.Join(" < ", numbersCollector), end);
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid Number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The Number Exceeds The Maximum Value Of Int32!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The Number Is Not In Range!");
        }
    }

    static int GetNumber(int start, int end)
    {
        Console.Write("Enter a number: ");

        int number = int.Parse(Console.ReadLine());

        if (number <= start || number >= end)
        {
            throw new System.ArgumentOutOfRangeException();
        }

        return number;
    }
}