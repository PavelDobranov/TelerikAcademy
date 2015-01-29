// Problem 5. The Biggest of 3 Numbers
// Write a program that finds the biggest of three numbers.

using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        int numbersCount = 3;
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