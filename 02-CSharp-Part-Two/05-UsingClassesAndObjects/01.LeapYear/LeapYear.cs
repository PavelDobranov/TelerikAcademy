// Problem 1. Leap year
// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter an year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Is {0} leap year? : {1}", year, IsLeapYear(year));
    }

    static bool IsLeapYear(int year)
    {
        return DateTime.IsLeapYear(year);
    }
}