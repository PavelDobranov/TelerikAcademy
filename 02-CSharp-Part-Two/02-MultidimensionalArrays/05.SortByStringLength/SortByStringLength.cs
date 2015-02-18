// Problem 5. Sort by string length
// You are given an array of strings. Write a method that sorts the array by the length
// of its elements (the number of characters composing them).

using System;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        // **Note for input see Tests.txt

        Console.Write("Enter array elements (separated by ','): ");
        string arrayInput = Console.ReadLine();
        string[] array = ParseArrayOfStrings(arrayInput);

        Array.Sort(array, (a, b) => a.Length - b.Length);

        Console.WriteLine("Result: {0}", string.Join(", ", array));
    }

    static string[] ParseArrayOfStrings(string arrayInput)
    {
        return arrayInput.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
}