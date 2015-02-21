// Problem 8. Number as array
// Write a method that adds two positive integer numbers represented as arrays of digits
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string firstNumber = Console.ReadLine();

        Console.Write("Enter second number: ");
        string secondNumber = Console.ReadLine();

        int[] firstNumberArray = GetReversedDigitsAsArray(firstNumber);
        int[] secondNumberArray = GetReversedDigitsAsArray(secondNumber);

        AddNumbersAsArray(firstNumberArray, secondNumberArray);
    }

    static void AddNumbersAsArray(int[] firstNumberArray, int[] secondNumberArray)
    {
        Stack<int> resultCollection = new Stack<int>();

        int[] longerArray = firstNumberArray.Length > secondNumberArray.Length ? firstNumberArray : secondNumberArray;
        int[] shorterArray = secondNumberArray.Length < firstNumberArray.Length ? secondNumberArray : firstNumberArray;

        int decimalBase = 10;
        int digitsSum;
        int temp = 0;

        for (int digitPosition = 0; digitPosition < longerArray.Length; digitPosition++)
        {
            if (digitPosition < shorterArray.Length)
            {
                digitsSum = longerArray[digitPosition] + shorterArray[digitPosition] + temp;
            }
            else
            {
                digitsSum = longerArray[digitPosition] + temp;
            }

            if (digitsSum / decimalBase > 0)
            {
                resultCollection.Push(digitsSum % decimalBase);
                temp = digitsSum / decimalBase;
            }
            else
            {
                resultCollection.Push(digitsSum);
                temp = 0;
            }
        }

        if (temp > 0)
        {
            resultCollection.Push(temp);
        }

        Console.WriteLine(string.Join("", resultCollection));
    }

    static int[] GetReversedDigitsAsArray(string number)
    {
        int[] result = new int[number.Length];

        for (int position = 1; position <= number.Length; position++)
        {
            result[position - 1] = number[number.Length - position] - '0';
        }

        return result;
    }
}