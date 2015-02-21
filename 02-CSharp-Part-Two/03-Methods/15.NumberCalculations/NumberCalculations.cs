// Problem 15.* Number calculations
// Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
// Use generic method (read in Internet about generic methods in C#).

using System;

class NumberCalculations
{
    static void Main()
    {
        int[] set = { 1, 2, 3, 4 };
        //double[] set = { 3.24, 1.4, 4.4, 12.5 };
        //decimal[] set = { 134.56m, 13.3m, 155.5m, 12.8m };

        Console.WriteLine("Maximal element: {0}", GetMaxValue(set));

        Console.WriteLine("Minimal element: {0}", GetMinValue(set));

        Console.WriteLine("Sum of all elements: {0}", GetSumOfElements(set));

        Console.WriteLine("Product of all elements: {0}", GetProductOfElements(set));

        Console.WriteLine("Avarege sum of all elements: {0}", GetAverageValueOfElements(set));
    }

    static T GetMaxValue<T>(T[] set) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        T max = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            if (set[index].CompareTo(max) > 0)
            {
                max = set[index];
            }
        }

        return max;
    }

    static T GetMinValue<T>(T[] set) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        T min = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            if (set[index].CompareTo(min) < 0)
            {
                min = set[index];
            }
        }

        return min;
    }

    static T GetSumOfElements<T>(T[] set) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        T sum = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            sum += (dynamic)set[index];
        }

        return sum;
    }

    static T GetProductOfElements<T>(T[] set) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        T product = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            product *= (dynamic)set[index];
        }

        return product;
    }

    static T GetAverageValueOfElements<T>(T[] set) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        T sum = set[0];

        for (int index = 1; index < set.Length; index++)
        {
            sum += (dynamic)set[index];
        }

        return sum /= (dynamic)set.Length;
    }
}