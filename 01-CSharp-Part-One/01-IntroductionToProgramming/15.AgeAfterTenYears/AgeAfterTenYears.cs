// Problem 15.* Age after 10 Years
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

public class AgeAfterTenYears
{
    static void Main()
    {
        int periodInYears = 10;

        Console.Write("Please enter your age: ");
        int currentAge = int.Parse(Console.ReadLine());

        Console.WriteLine("In {0} years, you'll be {1} years old", periodInYears, currentAge + periodInYears);
    }
}