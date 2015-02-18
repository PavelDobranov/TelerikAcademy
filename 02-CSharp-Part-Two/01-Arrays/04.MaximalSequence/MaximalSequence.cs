// Problem 4. Maximal sequence
// Write a program that finds the maximal sequence of equal elements in an array.
// Example: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 --> 2, 2, 2

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(input);

        Console.Write("Result: ");
        PrintMaximalSequenceOfEqualElements(array);
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

    static void PrintMaximalSequenceOfEqualElements(int[] array)
    {
        int currentSequenceLength = 1;
        int maxSequenceLength = currentSequenceLength;
        int maxSequenceEndPosition = 0;

        for (int element = 0; element < array.Length - 1; element++)
        {
            if (array[element] == array[element + 1])
            {
                currentSequenceLength++;

                if (currentSequenceLength > maxSequenceLength)
                {
                    maxSequenceLength = currentSequenceLength;
                    maxSequenceEndPosition = element + 1;
                }
            }
            else
            {
                currentSequenceLength = 1;
            }
        }
        
        for (int position = maxSequenceEndPosition; position > maxSequenceEndPosition - maxSequenceLength; position--)
        {
            Console.Write("{0} ", array[position]);
        }

        Console.WriteLine();
    }
}