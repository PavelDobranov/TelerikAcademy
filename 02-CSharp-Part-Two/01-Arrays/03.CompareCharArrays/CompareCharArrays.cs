// Problem 3. Compare char arrays
// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter the firts array elements (separated by ','): ");
        string input = Console.ReadLine();
        char[] fisrtArray = ParseArrayOfChars(input);

        Console.Write("Enter the second array elements (separated by ','): ");
        input = Console.ReadLine();
        char[] secondtArray = ParseArrayOfChars(input);

        string result = string.Empty;

        int comparisonResult = CompareTwoArraysOfChars(fisrtArray, secondtArray);

        if (comparisonResult == 1)
        {
            Console.WriteLine("First: {0}", string.Join(", ", fisrtArray));
            Console.WriteLine("Second: {0}", string.Join(", ", secondtArray));
        }
        else if (comparisonResult == 2)
        {
            Console.WriteLine("First: {0}", string.Join(", ", fisrtArray));
            Console.WriteLine("Second: {0}", string.Join(", ", secondtArray));
        }
        else
        {
            Console.WriteLine("Arrays are equal");
        }
    }

    static char[] ParseArrayOfChars(string input)
    {
        string[] stringArray = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        char[] result = new char[stringArray.Length];

        for (int position = 0; position < stringArray.Length; position++)
        {
            result[position] = char.Parse(stringArray[position]);
        }

        return result;
    }

    static int CompareTwoArraysOfChars(char[] fisrtArray, char[] secondtArray)
    {
        for (int position = 0; position < Math.Min(fisrtArray.Length, secondtArray.Length); position++)
        {
            if (fisrtArray[position] < secondtArray[position])
            {
                return 1; // first array is lexicographically first
            }

            if (fisrtArray[position] > secondtArray[position])
            {
                return 2; // second array is lexicographically first
            }
        }

        if (fisrtArray.Length == secondtArray.Length)
        {
            return 0; // arrays are equal
        }
        else if (fisrtArray.Length < secondtArray.Length)
        {
            return 1; // first array is lexicographically first
        }
        else
        {
            return 2; // first array is lexicographically first
        }
    }
}