// Problem 14.* Current Date and Time
// Create a console application that prints the current date and time. Find out how in Internet.

using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime currentDateAndTime = DateTime.Now;

        Console.WriteLine("Current date and time: {0}", currentDateAndTime);
    }
}