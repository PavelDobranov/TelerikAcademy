// Problem 9. Forbidden words
// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

        string result = ReplaceForbiddenWords(text, forbiddenWords);

        Console.WriteLine("Result: \n{0}", result);
    }

    static string ReplaceForbiddenWords(string text, string[] forbiddenWords)
    {
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            string asteriksString = (new string('*', forbiddenWords[i].Length));

            text = text.Replace(forbiddenWords[i], asteriksString);
        }

        return text;
    }
}