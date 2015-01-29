// Problem 6. The Biggest of Five Numbers
// Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        int numbersCount = 5;
        double[] numbers = new double[numbersCount];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number [{0}]: ", i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
        }

        double biggestNumber = GetBiggestNumber(numbers);

        Console.WriteLine("Biggest number: {0}", biggestNumber);
    }

    static double GetBiggestNumber(double[] numbers)
    {
        double biggestNumber = double.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > biggestNumber)
            {
                biggestNumber = numbers[i];
            }
        }

        return biggestNumber;
    }
}