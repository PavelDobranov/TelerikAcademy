﻿// Problem 8. Square Root
// Create a console application that calculates and prints the square root of the number 12345.
// Find in Internet “how to calculate square root in C#”.

using System;

public class SquareRoot
{
    static void Main()
    {
        int number = 12345;

        double result = Math.Sqrt(number);

        Console.WriteLine("The square root of the number 12345 is: {0}", result);
    }
}