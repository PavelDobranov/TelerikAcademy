// Problem 7. Selection sort
// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
// find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSortAlgorithm
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(input);

        int[] sortedArray = SelectionSort(array);
        Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedArray));
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

    static int[] SelectionSort(int[] array)
    {
        int[] result = new int[array.Length];

        Array.Copy(array, result, array.Length);

        for (int startIndex = 0; startIndex < array.Length; startIndex++)
        {
            int minIndex = startIndex;

            for (int checkIndex = startIndex + 1; checkIndex < array.Length; checkIndex++)
            {
                if (array[checkIndex] < array[minIndex])
                {
                    minIndex = checkIndex;
                }
            }

            if (minIndex != startIndex)
            {
                array[startIndex] += array[minIndex];
                array[minIndex] = array[startIndex] - array[minIndex];
                array[startIndex] -= array[minIndex];
            }
        }

        return array;
    }
}