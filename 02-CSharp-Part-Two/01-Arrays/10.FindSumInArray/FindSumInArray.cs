// Problem 10. Find sum in array
// Write a program that finds in given array of integers a sequence of given sum S (if present).
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 --> 4, 2, 5

using System;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(input);

        Console.Write("Enter sum S: ");
        int sumS = int.Parse(Console.ReadLine());

        Console.Write("Result: ");
        PrintSumInArray(array, sumS);
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

    static void PrintSumInArray(int[] array, int sum)
    {
        int startIndex = 0;
        int endIndex = startIndex;
        int currentSum = 0;

        while (startIndex < array.Length - 1)
        {
            if (endIndex == array.Length)
            {
                startIndex++;
                endIndex = startIndex;
                currentSum = 0;
            }

            currentSum += array[endIndex];

            if (currentSum == sum)
            {
                for (int position = startIndex; position <= endIndex; position++)
                {
                    Console.Write("{0} ", array[position]);
                }
            }

            endIndex++;
        }

        Console.WriteLine();
    }
}