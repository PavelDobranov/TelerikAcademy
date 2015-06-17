// Problem 4. Sub-string in text
// Write a program that finds how many times a sub-string is contained in a given text 
// (perform case insensitive search).

using System;

class SubstringInText
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";

        int result = CountSubstringInText(text, substring);

        Console.WriteLine("Result: {0}", result);
    }

    static int CountSubstringInText(string text, string substring)
    {
        int counter = 0;

        text = text.ToLower();

        while (text.IndexOf(substring) != -1)
        {
            int position = text.LastIndexOf(substring);

            if (text.Substring(position, substring.Length) != string.Empty)
            {
                counter++;
                text = text.Remove(position);
            }
        }

        return counter;
    }
}