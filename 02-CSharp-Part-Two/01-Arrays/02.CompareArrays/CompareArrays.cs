// Problem 2. Compare arrays
// Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class ArraysComparison
{
    static void Main()
    {
        Console.Write("Enter the firts array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] fisrtArray = ParseArrayOfIntegers(input);

        Console.Write("Enter the second array elements (separated by ','): ");
        input = Console.ReadLine();
        int[] secondtArray = ParseArrayOfIntegers(input);

        string result = string.Empty;

        if (CompareTwoArrays(fisrtArray, secondtArray))
        {
            result = "Arrays are equal";
        }
        else
        {
            result = "Arrays are not equal";
        }

        Console.WriteLine("Result: {0}", result);
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

    static bool CompareTwoArrays(int[] fisrtArray, int[] secondtArray)
    {
        if (fisrtArray.Length != secondtArray.Length)
        {
            return false;
        }

        for (int position = 0; position < fisrtArray.Length; position++)
        {
            if (fisrtArray[position] != secondtArray[position])
            {
                return false;
            }
        }

        return true;
    }
}