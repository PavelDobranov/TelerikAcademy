// Problem 2. IEnumerable extensions
// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
// sum, product, min, max, average.

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class TestIEnumerableExtensions
    {
        public static void Main()
        {
            var collection = new List<int> { 3, 4, 2, 5 };

            Console.WriteLine("Sum: {0}", collection.Sum());
            Console.WriteLine("Product: {0}", collection.Product());
            Console.WriteLine("Min: {0}", collection.Min());
            Console.WriteLine("Max: {0}", collection.Max());
            Console.WriteLine("Average: {0}", collection.Average());
        }
    }
}
