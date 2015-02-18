// Problem 16.* Subset with sum S
// We are given an array of integers and a number S.
// Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;

class SubsetWithSumS
{
    static int[] array;
    static bool[,] possibleSum;
    static bool[,] isCalculated;

    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        array = ParseArrayOfIntegers(input);

        Console.Write("Enter sum S: ");
        int sum = int.Parse(Console.ReadLine());

        possibleSum = new bool[array.Length, sum + 1];
        isCalculated = new bool[array.Length, sum + 1];

        bool possible = CalculatePossibleSum(array.Length - 1, sum);

        if (possible)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("Not possible");
        }
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

    static bool CalculatePossibleSum(int position, int sum)
    {
        if (sum < 0 || position < 0)
        {
            return false;
        }

        if (!isCalculated[position, sum])
        {
            possibleSum[position, sum] = (array[position] == sum) || CalculatePossibleSum(position - 1, sum) || CalculatePossibleSum(position - 1, sum - array[position]);
            isCalculated[position, sum] = true;
        }

        return possibleSum[position, sum];
    }
}