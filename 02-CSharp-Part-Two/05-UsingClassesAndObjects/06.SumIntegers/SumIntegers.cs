// Problem 6. Sum integers
// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum

using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter integer values, separated by spaces: ");
        string numbers = Console.ReadLine();

        int sum = GetSumOfIntegers(numbers);

        Console.WriteLine("Sum = {0}", sum);
    }

    static int GetSumOfIntegers(string numbers)
    {
        int sum = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         .Select(n => int.Parse(n))
                         .Sum();

        return sum;
    }
}