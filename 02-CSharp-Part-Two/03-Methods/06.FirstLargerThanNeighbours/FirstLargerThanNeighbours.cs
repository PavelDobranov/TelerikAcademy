// Problem 6. First larger than neighbours
// Write a method that returns the index of the first element in array that is larger than its neighbours,
// or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;
using System.Linq;
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string arrayInput = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(arrayInput);

        int result = GetFirstLargerThanNeighbours(array);
        Console.WriteLine("Result: {0}", result);
    }

    static int[] ParseArrayOfIntegers(string numbers)
    {
        int[] result = numbers
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .ToArray();

        return result;
    }

    static int GetFirstLargerThanNeighbours(int[] array)
    {
        for (int position = 0; position < array.Length; position++)
        {
            if (IsLargerThanNeighbours(array, position))
            {
                return position;
            }
        }

        return -1;
    }

    static bool IsLargerThanNeighbours(int[] array, int position)
    {
        if (position == 0)
        {
            return array[position] > array[position + 1];
        }

        if (position == array.Length - 1)
        {
            return array[position] > array[position - 1];
        }

        return array[position] > array[position - 1] && array[position] > array[position + 1];
    }
}