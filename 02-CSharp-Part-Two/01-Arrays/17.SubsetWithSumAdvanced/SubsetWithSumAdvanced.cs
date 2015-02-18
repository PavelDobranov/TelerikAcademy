// Problem 17.* Subset K with sum S
// Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
// Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class SubsetWithSumAdvanced
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());

        int[] array = new int[numberN];

        Console.WriteLine("Enter the array elements:");
        for (int element = 0; element < array.Length; element++)
        {
            Console.Write("element[{0}]: ", element);
            array[element] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number K: ");
        int subsetLength = int.Parse(Console.ReadLine());

        Console.Write("Enter target sum S: ");
        int sum = int.Parse(Console.ReadLine());

        int[] indices = new int[array.Length];

        Console.Write("Result");
        Combination(array, indices, subsetLength, sum, 0, 0);
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

    static void Combination(int[] array, int[] indices, int length, int sum, int position, int next)
    {
        if (position > length) return;

        for (int i = next; i < array.Length; i++)
        {
            indices[position] = i;

            if (position == length) Check(array, indices, length, sum);

            Combination(array, indices, length, sum, position + 1, i + 1);
        }
    }

    static void Check(int[] array, int[] indices, int length, int sum)
    {
        int currentSum = 0;

        for (int position = 0; position <= length; position++)
        {
            currentSum += array[indices[position]];
        }

        if (currentSum == sum)
        {
            for (int position = 0; position <= length; position++)
            {
                Console.Write(array[indices[position]] + (position == length ? " = " + sum + "\n" : " + "));
            }
        }
    }
}