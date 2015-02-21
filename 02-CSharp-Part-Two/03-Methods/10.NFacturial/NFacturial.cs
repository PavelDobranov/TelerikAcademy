// Problem 10. N Factorial
// Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Numerics;

class NFacturial
{
    static void Main()
    {
        int rangeMin = 1;
        int rangeMax = 100;

        Console.WriteLine("Result:");
        for (int number = rangeMin; number <= rangeMax; number++)
        {
            Console.WriteLine(GetFactorial(number));
        }
    }

    static BigInteger GetFactorial(int number)
    {
        BigInteger factorial = 1;

        do
        {
            factorial *= number;
            number--;
        }
        while (number > 0);

        return factorial;
    }    
}