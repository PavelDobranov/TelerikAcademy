// Problem 10.* Beer Time
// A beer time is after 1:00 PM and before 3:00 AM.
// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
// a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time
// according to the definition above or invalid time if the time cannot be parsed.

using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter a time [hh:mm tt]: ");
        DateTime time = DateTime.Parse(Console.ReadLine());

        string result = IsBeerTime(time);

        Console.WriteLine("Result: {0}", result);
    }

    static string IsBeerTime(DateTime time)
    {
        DateTime beerTimeAfter = DateTime.Parse("1:00 PM");
        DateTime beerTimeBefore = DateTime.Parse("3:00 AM");

        if (time.Hour >= beerTimeAfter.Hour || time.Hour < beerTimeBefore.Hour)
        {
            return "beer time";
        }
        else
        {
            return "non-beer time";
        }
    }
}