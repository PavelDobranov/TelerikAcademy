// Problem 17. Longest string
// Write a program to return the string with maximum length from an array of strings.
// Use LINQ.

namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LongestStringQuery
    {
        public static void Main()
        {
            var words = new[] { "Pesho", "Ivan", "Stoyqn", "Anatoli" };
            
            Console.WriteLine("---------");
            Console.WriteLine("All words");
            Console.WriteLine("---------");
            Console.WriteLine(string.Join(", ", words));

            // Linq query
            var longestWord = from word in words
                              where word.Length == words.Max(w => w.Length)
                              select word;

            string result = string.Join("", longestWord);

            // Lambda
            //var result = words
            //                .OrderByDescending(w => w.Length)
            //                .FirstOrDefault();

            Console.WriteLine("------------------------");
            Console.WriteLine("Word with maximum length");
            Console.WriteLine("------------------------");
            Console.WriteLine(result);
        }
    }
}