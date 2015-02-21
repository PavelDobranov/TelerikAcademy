// Problem 14. Integer calculations
// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        Console.Write("Enter the array elements (separated by ','): ");
        string setInput = Console.ReadLine();
        int[] set = ParseArrayOfIntegers(setInput);

        Console.WriteLine("Maximal element: {0}", GetMaxValue(set));

        Console.WriteLine("Minimal element: {0}", GetMinValue(set));

        Console.WriteLine("Sum of all elements: {0}", GetSumOfElements(set));

        Console.WriteLine("Product of all elements: {0}", GetProductOfElements(set));

        Console.WriteLine("Avarege sum of all elements: {0}", GetAverageValueOfElements(set));
    }

    static int[] ParseArrayOfIntegers(string numbers)
    {
        int[] result = numbers
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .ToArray();

        return result;
    }

    static int GetMaxValue(int[] set)
    {
        int max = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            if (set[index] > max)
            {
                max = set[index];
            }
        }

        return max;
    }

    static int GetMinValue(int[] set)
    {
        int min = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            if (set[index] < min)
            {
                min = set[index];
            }
        }

        return min;
    }

    static int GetSumOfElements(int[] set)
    {
        int sum = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            sum += set[index];
        }

        return sum;
    }

    static long GetProductOfElements(int[] set)
    {
        long product = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            product *= set[index];
        }

        return product;
    }

    static double GetAverageValueOfElements(int[] set)
    {
        double sum = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            sum += set[index];
        }

        return sum /= set.Length;
    }
}