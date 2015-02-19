// Problem 6. Maximal K sum
// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class MaximalSumOfElements
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int numberK = int.Parse(Console.ReadLine());

        if (numberN < numberK)
        {
            Console.WriteLine("The length of subset elements must be smaller or equal to the array's length!");
            return;
        }

        int[] array = new int[numberN];

        Console.WriteLine("Enter the array elements:");

        for (int element = 0; element < array.Length; element++)
        {
            Console.Write("element[{0}]: ", element);
            array[element] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Entered array: {0}", string.Join(", ", array));

        PrintMaximalSumOfElements(array, numberK);
    }

    static void PrintMaximalSumOfElements(int[] array, int elementsCount)
    {
        Array.Sort(array, (a, b) => b - a);

        int maxSum = 0;

        Console.Write("Subset elements: ");

        for (int element = 0; element < elementsCount; element++)
        {
            maxSum += array[element];
            Console.Write("{0} ", array[element]);
        }

        Console.WriteLine("Maximal sum: {0}", maxSum);
    }
}