// Problem 5. Larger than neighbours
// Write a method that checks if the element at given position in given array of integers
// is larger than its two neighbours (when such exist).

using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string arrayInput = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(arrayInput);

        Console.Write("Enter element position: ");
        int position = int.Parse(Console.ReadLine());

        bool isLarger = IsLargerThanNeighbours(array, position);
        Console.WriteLine("Is larger than its two neighbours?: {0}", isLarger);
    }

    static int[] ParseArrayOfIntegers(string numbers)
    {
        int[] result = numbers
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .ToArray();

        return result;
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