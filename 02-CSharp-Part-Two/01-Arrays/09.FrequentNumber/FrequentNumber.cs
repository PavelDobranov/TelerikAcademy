// Problem 9. Frequent number
// Write a program that finds the most frequent number in an array. 
// Example:	4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 --> 4 (5 times)

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string input = Console.ReadLine();
        int[] array = ParseArrayOfIntegers(input);

        PrintMostFrequentNumber(array);
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

    static void PrintMostFrequentNumber(int[] array)
    {
        Array.Sort(array);

        int mostFrequentNumber = array[0];
        int mostFrequentNumberCount = 1;
        int numberCount = 1;

        for (int position = 0; position < array.Length - 1; position++)
        {
            if (array[position] == array[position + 1])
            {
                numberCount++;

                if (numberCount > mostFrequentNumberCount)
                {
                    mostFrequentNumberCount = numberCount;
                    mostFrequentNumber = array[position];
                }
            }
            else
            {
                numberCount = 1;
            }
        }

        Console.WriteLine("{0} ({1} times)", mostFrequentNumber, mostFrequentNumberCount);
    }
}