// Problem 4. Binary search
// Write a program, that reads from the console an array of N integers and an integer K,
// sorts the array and using the method Array.BinSearch() finds the largest number
// in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        // **Note for input see Tests.txt

        Console.Write("Enter the firts array elements (separated by ','): ");
        string arrayInput = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(arrayInput);

        Console.Write("Enter number K: ");
        int numberK = int.Parse(Console.ReadLine());

        Array.Sort(array);
        int result = Array.BinarySearch(array, numberK);

        if (~result == 0)
        {
            Console.WriteLine("No smaller or equal element founded");
        }
        else if (result < -1)
        {
            Console.WriteLine("Result: {0}", array[~result - 1]);
        }
        else
        {
            Console.WriteLine("Result: {0}", array[result]);
        }
    }

    static int[] ParseArrayOfIntegers(string arrayInput)
    {
        string[] stringArray = arrayInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] result = new int[stringArray.Length];

        for (int position = 0; position < stringArray.Length; position++)
        {
            result[position] = int.Parse(stringArray[position]);
        }

        return result;
    }

    static int FindElementInArray(int[] array, int number)
    {
        Array.Sort(array);
        int result = Array.BinarySearch(array, number);

        return result;
    }
}