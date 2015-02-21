// Problem 4. Appearance count
// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string arrayInput = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(arrayInput);

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        CountInAppearanceInArray(number, array);
    }

    static int[] ParseArrayOfIntegers(string numbers)
    {
        int[] result = numbers
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .ToArray();

        return result;
    }

    static void CountInAppearanceInArray(int number, int[] array)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }

        Console.WriteLine("Number {0} appears {1} times in the array", number, counter);
    }
}