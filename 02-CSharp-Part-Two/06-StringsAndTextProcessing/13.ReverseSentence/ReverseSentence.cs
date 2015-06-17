// Problem 13. Reverse sentence
// Write a program that reverses the words in given sentence.

using System;
using System.Collections.Generic;
using System.Linq;

class ReverseSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";

        string result = GetReversedSentence(sentence);

        Console.WriteLine("Result: {0}", result);
    }

    static string GetReversedSentence(string sentence)
    {
        char[] punctuations = new char[] { ' ', '.', ',', ':', ';', '!', '?' };

        List<string> words = new List<string>(sentence.Split(punctuations, StringSplitOptions.RemoveEmptyEntries));
        words.Reverse();

        int punctuationPosition = 0;

        foreach (char character in sentence)
        {
            if (character == ' ')
            {
                punctuationPosition++;
            }

            if (punctuations.Contains(character) && character != ' ')
            {
                words[punctuationPosition] += character;
            }
        }

        return string.Join(" ", words);
    }
}