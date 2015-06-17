// Problem 18. Extract e-mails
// Write a program for extracting all email addresses from given text.
// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text =
            "Ultimately, the best thing would be to show people by example.\n"
            + "At the top, have a little table that shows:\n"
            + "Your Website: http://www.mycoolsite.com]\n"
            + "Your Personal Email: myname@gmail.com\n"
            + "Your ContactForm Email: contactform.mycoolsite@gmail.com";

        Console.WriteLine("Result: ");
        PrintEmailsFromText(text);
    }

    static void PrintEmailsFromText(string text)
    {
        // maches email using regular expression
        // http://stackoverflow.com/questions/5342375/c-sharp-regex-email-validation

        Regex pattern = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
        
        MatchCollection resultCollection = pattern.Matches(text);

        foreach (var result in resultCollection)
        {
            Console.WriteLine(result);
        }
    }
}