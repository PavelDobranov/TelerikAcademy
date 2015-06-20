// Problem 3. Min, Max, Sum and Average of N Numbers
// Write a program that reads from the console a sequence of n integer numbers
// and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;

public class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter number [n]: ");
        int numbersCount = int.Parse(Console.ReadLine());

        int startNumber = 1;

        int numbersMinValue = int.MaxValue;
        int numbersMaxValue = int.MinValue;
        int numbersSum = 0;
        int inputNumber;

        for (int number = startNumber; number <= numbersCount; number++)
        {
            Console.Write("Enter number [{0}]: ", number);
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber > numbersMaxValue)
            {
                numbersMaxValue = inputNumber;
            }

            if (inputNumber < numbersMinValue)
            {
                numbersMinValue = inputNumber;
            }

            numbersSum += inputNumber;
        }

        double numbersAverage = (double)numbersSum / numbersCount;

        Console.WriteLine("min = {0}", numbersMinValue);
        Console.WriteLine("max = {0}", numbersMaxValue);
        Console.WriteLine("sum = {0}", numbersSum);
        Console.WriteLine("avg = {0:F2}", numbersAverage);
    }
}