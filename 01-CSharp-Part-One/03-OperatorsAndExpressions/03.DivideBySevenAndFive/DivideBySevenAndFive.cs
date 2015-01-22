﻿// Problem 3. Divide by 7 and 5
// Write a Boolean expression that checks for given integer if it can be divided 
// (without remainder) by 7 and 5 at the same time.

using System;
class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Please enter an integer value: ");
        int number = int.Parse(Console.ReadLine());
        int divider = 7 * 5;

        bool result = number % divider == 0 ? true : false;

        Console.WriteLine("Divided by 7 and 5? : {0}", result);
    }
}