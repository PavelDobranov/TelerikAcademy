// Problem 13.* Merge sort
// Write a program that sorts an array of integers using the Merge sort algorithm.﻿

using System;

class MergeSortAlgorithm
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(input);

        int[] tempArray = new int[array.Length];

        MergeSort(array, tempArray, 0, array.Length - 1);
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

    static void MergeSort(int[] array, int[] temp, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int middle = start + (end - start) / 2;

        MergeSort(array, temp, start, middle);
        MergeSort(array, temp, middle + 1, end);

        CompareAndSort(array, temp, start, middle, end);
    }

    static void CompareAndSort(int[] array, int[] temp, int start, int middle, int end)
    {
        int i = start;
        int l = start;
        int m = middle + 1;

        while (l <= middle && m <= end)
        {
            temp[i++] = (array[l] > array[m]) ? array[m++] : array[l++];
        }

        while (l <= middle)
        {
            temp[i++] = array[l++];
        }

        while (m <= end)
        {
            temp[i++] = array[m++];
        }

        for (int j = start; j <= end; j++)
        {
            array[j] = temp[j];
        }
    }
}