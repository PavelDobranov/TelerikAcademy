// Problem 18.* Trailing Zeroes in N!
// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
// Your program should work well for very big numbers, e.g. n=100000.

using System;

class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int trailingZeroes = GetTrailingZeroes(number);

        Console.WriteLine("{0}! has {1} trailing zeroes", number, trailingZeroes);
    }

    static int GetTrailingZeroes(int number)
    {
        int result = 0;
        int devider = 5;

        do
        {
            result += (number / devider);
            devider *= 5;
        } while (devider <= number);

        return result;
    }
}