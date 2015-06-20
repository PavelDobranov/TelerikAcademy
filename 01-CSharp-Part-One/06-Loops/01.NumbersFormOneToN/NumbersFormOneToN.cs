// Problem 1. Numbers from 1 to N
// Write a program that enters from the console a positive integer n and prints 
// all the numbers from 1 to n, on a single line, separated by a space.

using System;

public class NumbersFormOneToN
{
    static void Main()
    {
        Console.Write("Enter number [n]: ");
        int numbersCount = int.Parse(Console.ReadLine());

        int startNumber = 1;

        for (int number = startNumber; number <= numbersCount; number++)
        {
            Console.Write("{0} ", number);
        }
    }
}