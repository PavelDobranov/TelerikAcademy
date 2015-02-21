// Problem 9. Sorting array
// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string arrayInput = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(arrayInput);

        SortArray(array, true);
        Console.Write("Sorted in ascending order: ");
        PrintArray(array);

        SortArray(array, false);
        Console.Write("Sorted in descending order: ");
        PrintArray(array);
    }

    static int[] ParseArrayOfIntegers(string numbers)
    {
        int[] result = numbers
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .ToArray();

        return result;
    }

    static void SortArray(int[] array, bool ascending)
    {
        if (ascending)
        {
            AscendingSort(array);
        }
        else
        {
            DescendingSort(array);
        }
    }

    static void AscendingSort(int[] array)
    {
        int maxElementIndex;

        for (int endIndex = array.Length - 1; endIndex >= 0; endIndex--)
        {
            maxElementIndex = GetMaxElementIndex(array, 0, endIndex);

            if (maxElementIndex != endIndex)
            {
                Swap(array, maxElementIndex, endIndex);
            }
        }
    }

    static void DescendingSort(int[] array)
    {
        int maxElementIndex;

        for (int startIndex = 0; startIndex < array.Length; startIndex++)
        {
            maxElementIndex = GetMaxElementIndex(array, startIndex, array.Length - 1);

            if (maxElementIndex != startIndex)
            {
                Swap(array, maxElementIndex, startIndex);
            }
        }
    }

    static int GetMaxElementIndex(int[] array, int startIndex, int endIndex)
    {
        int maxElementIndex = startIndex;

        for (int index = startIndex + 1; index <= endIndex; index++)
        {
            if (array[maxElementIndex] < array[index])
            {
                maxElementIndex = index;
            }
        }

        return maxElementIndex;
    }

    static void Swap(int[] array, int firstIndex, int secondIndex)
    {
        array[firstIndex] += array[secondIndex];
        array[secondIndex] = array[firstIndex] - array[secondIndex];
        array[firstIndex] -= array[secondIndex];
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}