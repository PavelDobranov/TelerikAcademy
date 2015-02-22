﻿// Problem 2. Numbers Not Divisible by 3 and 7
// Write a program that enters from the console a positive integer n and prints 
// all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

using System;

class NotDivisibleByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Enter number [n]: ");
        int numbersCount = int.Parse(Console.ReadLine());

        int startNumber = 1;

        for (int number = startNumber; number <= numbersCount; number++)
        {
            if (number % 3 != 0 && number % 7 != 0)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}