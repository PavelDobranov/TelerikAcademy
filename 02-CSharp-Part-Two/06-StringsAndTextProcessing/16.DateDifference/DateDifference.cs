// Problem 16. Date difference
// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        string firstDateInput = "18.01.2014";
        string secondDateInput = "20.08.2014";

        PrintDateDifference(firstDateInput, secondDateInput);
    }

    static void PrintDateDifference(string firstDateInput, string secondDateInput)
    {
        DateTime firstDate = DateTime.ParseExact(firstDateInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondDateInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        TimeSpan distance = (firstDate - secondDate);

        Console.WriteLine("Difference: {0} days", Math.Abs(distance.TotalDays));
    }
}