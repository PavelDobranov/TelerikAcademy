// Problem 1. Allocate array
// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main()
    {
        int arrayLength = 20;
        int[] array = new int[arrayLength];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = index * 5;
        }

        Console.WriteLine(string.Join(" ", array));
    }
}