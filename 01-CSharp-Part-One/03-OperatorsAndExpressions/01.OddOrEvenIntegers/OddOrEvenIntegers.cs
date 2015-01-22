// Problem 1. Odd or Even Integers
// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Please enter an integer value: ");
        int number = int.Parse(Console.ReadLine());

        bool result = number % 2 == 0 ? false : true;
        Console.WriteLine("Odd? : {0}", result);
    }
}