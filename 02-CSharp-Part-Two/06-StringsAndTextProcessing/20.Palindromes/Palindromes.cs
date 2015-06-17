// Problem 20. Palindromes
// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main()
    {
        string text =
            "ABBA was a Swedish pop group formed in Stockholm in 1972, comprising Agnetha Fältskog,\n"
            + "Björn Ulvaeus, Benny Andersson, and Anni-Frid Lyngstad.\n"
            + "exe is a common filename extension denoting an executable file\n"
            + "(the main execution point of a computer program)";

        Console.WriteLine("Result: ");
        PrintPalindromes(text);
    }

    static void PrintPalindromes(string text)
    {
        char[] separators = { ' ', '.', ',', '!', '?' };
        string[] textToWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < textToWords.Length; i++)
        {
            text = textToWords[i].Trim();

            if (text.Length != 1 && IsPalindrom(text))
            {
                Console.WriteLine(text);
            }
        }
    }

    static bool IsPalindrom(string word)
    {
        for (int i = 1; i <= word.Length / 2; i++)
        {
            if (word[i - 1] != word[word.Length - i])
            {
                return false;
            }
        }

        return true;
    }    
}