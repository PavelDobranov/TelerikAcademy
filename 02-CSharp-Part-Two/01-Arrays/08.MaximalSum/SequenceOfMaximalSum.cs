// Problem 8. Maximal sum
// Write a program that finds the sequence of maximal sum in given array. 
// Example: 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 --> 2, -1, 6, 4
// Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class SequenceOfMaximalSum
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(input);

        Console.Write("Result: ");
        PrintSequenceOfMaximalSum(array);
    }

    static int[] ParseArrayOfIntegers(string input)
    {
        string[] stringArray = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] result = new int[stringArray.Length];

        for (int position = 0; position < stringArray.Length; position++)
        {
            result[position] = int.Parse(stringArray[position]);
        }

        return result;
    }

    static void PrintSequenceOfMaximalSum(int[] array)
    {
        int currentStartIndex = 0;
        int currentEndIndex = currentStartIndex;
        int currentSum = 0;
        int maxSumStartIndex = 0;
        int maxSumEndIndex = 0;
        int maxSum = 0;

        while (currentStartIndex < array.Length - 1)
        {
            if (currentEndIndex == array.Length)
            {
                currentStartIndex++;
                currentEndIndex = currentStartIndex;
                currentSum = 0;
            }

            currentSum += array[currentEndIndex];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxSumStartIndex = currentStartIndex;
                maxSumEndIndex = currentEndIndex;
            }

            currentEndIndex++;
        }

        while (maxSumStartIndex <= maxSumEndIndex)
        {
            Console.Write("{0} ", array[maxSumStartIndex]);
            maxSumStartIndex++;
        }

        Console.WriteLine();
    }
}