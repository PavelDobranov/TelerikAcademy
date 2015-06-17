// Problem 17. Date in Bulgarian
// Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Text;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        string inputDate = "18.01.2014 22:00:00";

        string result = PrintDateInBulgarian(inputDate);

        Console.WriteLine("Result: {0}", result);
    }

    static string PrintDateInBulgarian(string inputDate)
    {
        Console.OutputEncoding = Encoding.UTF8;

        DateTime date = DateTime.ParseExact(inputDate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        date = date.AddHours(6.5);

        CultureInfo bgCulture = new CultureInfo("bg-BG");

        string result = date.ToString("dddd dd.MM.yyyy HH:mm:ss", bgCulture);

        return result;
    }
}