// Problem 11. Binary search
// Write a program that finds the index of given element in a sorted array of integers
// by using the Binary search algorithm.

using System;

class BinarySearchAlgorithm
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(input);

        Console.Write("Enter key: ");
        int key = int.Parse(Console.ReadLine());

        int result = BinarySearch(array, key);

        if (result > 0)
        {
            Console.WriteLine("Key {0} found at index {1}", key, result);
        }
        else
        {
            Console.WriteLine("Key not found");
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

    static int BinarySearch(int[] array, int key)
    {
        int minIndex = 0;
        int maxIndex = array.Length - 1;
        int middle;

        while (maxIndex >= minIndex)
        {
            middle = minIndex + ((maxIndex - minIndex) / 2);

            if (array[middle] == key)
            {
                return middle;
            }
            else if (array[middle] < key)
            {
                minIndex = middle + 1;
            }
            else
            {
                minIndex = middle - 1;
            }
        }

        return -1;
    }
}