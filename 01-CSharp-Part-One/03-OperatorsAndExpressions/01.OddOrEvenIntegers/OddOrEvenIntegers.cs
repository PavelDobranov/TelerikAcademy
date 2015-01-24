// Problem 1. Odd or Even Integers
// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter an integer value: ");
        int number = int.Parse(Console.ReadLine());

        bool isOddNumber = number % 2 != 0;
        
        Console.WriteLine("Odd? : {0}", isOddNumber);
    }
}