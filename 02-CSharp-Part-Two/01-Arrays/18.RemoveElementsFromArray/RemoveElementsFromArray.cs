// Problem 18.* Remove elements from array
// Write a program that reads an array of integers and removes from it a minimal number of elements in such a way
// that the remaining array is sorted in increasing order.
// Print the remaining sorted array.

using System;

class RemoveElementsFromArray
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(input);

        int[] indices = new int[array.Length];

        Console.Write("Result: ");

        for (int length = array.Length - 1; length >= 0; length--)
        {
            Combination(array, indices, length, 0, 0);
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

    static void Combination(int[] array, int[] indices, int length, int position, int next)
    {
        if (position > length)
        {
            return;
        }

        for (int i = next; i < array.Length; i++)
        {
            indices[position] = i;

            if (position == length) Check(array, indices, length);

            Combination(array, indices, length, position + 1, i + 1);
        }
    }

    static void Check(int[] array, int[] indices, int length)
    {
        for (int position = 0; position < length; position++)
        {
            if (array[indices[position]] > array[indices[position + 1]])
            {
                return;
            }
        }

        for (int position = 0; position <= length; position++)
        {
            Console.Write(array[indices[position]] + (position == length ? "\n" : " "));
        }

        Environment.Exit(0);
    }
}