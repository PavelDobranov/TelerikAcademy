// Problem 6. Divisible by 7 and 3
// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace DivisibleBySevenAndThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class DivisibleBySevenAndThreeQuery
    {
        public static void Main()
        {
            int[] numbers = new int[] { 2, 63, 7, 12, 21, 44};

            Console.WriteLine("-----------");
            Console.WriteLine("All numbers");
            Console.WriteLine("-----------");
            Console.WriteLine(string.Join(", ", numbers));

            // Lambda
            var result = numbers.Where(n => n % 3 == 0 && n % 7 == 0);

            // Linq query
            //var result = from number in numbers
            //             where number % 3 == 0 && number % 7 == 0
            //             select number;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Numbers that are divisible by 7 and 3");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
