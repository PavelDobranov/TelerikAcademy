// Problem 8. Extract sentences
// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        Console.WriteLine("Result: ");
        ExtractAllSentences(text, word);
    }

    static void ExtractAllSentences(string text, string word)
    {
        char[] separator = { '.' };
        string[] sentences = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        string regularExpression = @"\b" + word + @"\b";

        for (int i = 0; i < sentences.Length; i++)
        {
            if (Regex.Matches(sentences[i], regularExpression).Count > 0)
            {
                Console.WriteLine("{0}.", sentences[i].Trim());
            }
        }
    }
}