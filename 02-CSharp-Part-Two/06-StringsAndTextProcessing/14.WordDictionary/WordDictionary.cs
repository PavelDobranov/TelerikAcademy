// Problem 14. Word dictionary
// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        string input =
            ".NET - platform for applications from Microsoft\n"
            + "CLR - managed execution environment for .NET\n"
            + "namespace - hierarchical organization of classes\n";

        char[] separator = { '\n' };
        string[] lines = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        string[,] dictionary = new string[lines.Length, 2];

        separator[0] = '-';

        for (int row = 0; row < lines.Length; row++)
        {
            string[] splitedLines = lines[row].Split(separator, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < splitedLines.Length; col++)
            {
                dictionary[row, col] = splitedLines[col].Trim();
            }
        }

        Console.Write("Type a word to translate: ");
        string word = Console.ReadLine();

        int key = GetWordDefinition(word, dictionary);

        if (key == -1)
        {
            Console.WriteLine("Word not found!");
        }
        else
        {
            Console.WriteLine("Definition: {0}", dictionary[key, 1]);
        }
    }

    static int GetWordDefinition(string word, string[,] dictionary)
    {
        for (int row = 0; row < dictionary.GetLength(0); row++)
        {
            if (word == dictionary[row, 0])
            {
                return row;
            }
        }
        return -1;
    }
}