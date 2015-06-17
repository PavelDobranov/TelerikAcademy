// Problem 19. Dates from text in Canada
// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class DatesFromTextTnCanada
{
    static void Main()
    {
        string text =
            "За да направите това, можете да влезете в студентската система и да направите своя избор.\n"
            + " Крайния срок е 08.01.2014 г. 10:00 AM. На 17.01.2014 г. ще имате упражнения в зала\n"
            + "Enterprise, където човек от екипа + асистенти ще могат да отговарят на вашите въпроси\n"
            + "от 10:00 до 18:00 часа. На 20.01.2014 г. ще се проведе публична защита на отборната\n"
            + "работа през целия ден в зала Light. Когато наближи, ще получите повече информация, но\n"
            + "датата е фиксирана. На 27.01.2014 г. ще направим финалното класиране и ще получите\n"
            + "информация кой продължава напред в академията на Телерик присъствено, както и ще разберете\n"
            + "оценките си от курса.";

        Console.WriteLine("Result: ");
        PrintDatesFromText(text);
    }

    static void PrintDatesFromText(string text)
    {
        string pattern = @"\d{2}.\d{2}.\d{4}";

        MatchCollection maches = Regex.Matches(text, pattern);

        CultureInfo caCulture = new CultureInfo("en-CA");

        for (int i = 0; i < maches.Count; i++)
        {
            string dateToString = maches[i].ToString();

            DateTime date = DateTime.ParseExact(dateToString, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            string result = date.ToString(caCulture);

            Console.WriteLine(result);
        }
    }
}