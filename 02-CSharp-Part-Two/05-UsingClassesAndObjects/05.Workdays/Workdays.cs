// Problem 5. Workdays
// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays
// specified preliminary as array.

using System;

class Workdays
{
    static void Main()
    {
        DateTime startDate = DateTime.Now;
        DateTime endDate = new DateTime(2016, 01, 19);

        int workdays = GetWorkdaysForPeriod(startDate, endDate);

        Console.WriteLine("Workdays from {0:dd.MM.yyyy} to {1:dd.MM.yyyy}: {2}", startDate, endDate, workdays);
    }

    static int GetWorkdaysForPeriod(DateTime startDate, DateTime endDate)
    {
        int workdays = 0;

        while (startDate <= endDate)
        {
            if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                if (IsPublicHoliday(startDate) == false)
                {
                    workdays++;
                }
            }

            startDate = startDate.AddDays(1);
        }

        return workdays;
    }

    static bool IsPublicHoliday(DateTime date)
    {
        // array of public holidays
        DateTime[] publicHolidays =     
        {  
            new DateTime(date.Year, 1, 1),           
            new DateTime(date.Year, 3, 3),          
            new DateTime(date.Year, 5, 1),          
            new DateTime(date.Year, 5, 2),          
            new DateTime(date.Year, 5, 6),          
            new DateTime(date.Year, 5, 24),         
            new DateTime(date.Year, 9, 22),         
            new DateTime(date.Year, 12, 24),        
            new DateTime(date.Year, 12, 25),        
            new DateTime(date.Year, 12, 26),        
            new DateTime(date.Year, 12, 31),
        };

        for (int i = 0; i < publicHolidays.Length; i++)
        {
            if (date == publicHolidays[i])
            {
                return true;
            }
        }

        return false;
    }
}