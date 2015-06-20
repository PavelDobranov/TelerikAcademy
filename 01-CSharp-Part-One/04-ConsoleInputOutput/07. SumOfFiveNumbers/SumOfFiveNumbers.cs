// Problem 7. Sum of 5 Numbers
// Write a program that enters 5 numbers (given in a single line, separated by a space),
// calculates and prints their sum

using System;

public class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers, separated by a space: ");
        string numbers = Console.ReadLine();

        string[] numbersAsArray = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        double sum = 0;

        foreach (var number in numbersAsArray)
        {
            sum += double.Parse(number);
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}