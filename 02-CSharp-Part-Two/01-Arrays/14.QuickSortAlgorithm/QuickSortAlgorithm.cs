// Problem 14. Quick sort
// Write a program that sorts an array of integers using the Quick sort algorithm.

using System;

class QuickSortAlgorithm
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(input);

        QuickSort(array, 0, array.Length - 1);
        Console.WriteLine("Sorted array: {0}", string.Join(", ", array));
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

    static void QuickSort(int[] array, int left, int right)
    {
        if (right > left)
        {
            int pivotIndex = Partition(array, left, right);

            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivotValue = array[left];

        int leftIndex = left;
        int rightIndex = right + 1;

        while (true)
        {
            while (array[++leftIndex] < pivotValue)
            {
                if (leftIndex >= right)
                {
                    break;
                }
            }

            while (array[--rightIndex] > pivotValue)
            {
                if (rightIndex <= left)
                {
                    break;
                }
            }

            if (leftIndex >= rightIndex)
            {
                break;
            }
            else
            {
                Swap(array, leftIndex, rightIndex);
            }
        }

        if (rightIndex == left)
        {
            return rightIndex;
        }

        Swap(array, left, rightIndex);

        return rightIndex;
    }

    static void Swap(int[] array, int firstIndex, int secondIndex)
    {
        array[firstIndex] = array[firstIndex] + array[secondIndex];
        array[secondIndex] = array[firstIndex] - array[secondIndex];
        array[firstIndex] = array[firstIndex] - array[secondIndex];
    }
}