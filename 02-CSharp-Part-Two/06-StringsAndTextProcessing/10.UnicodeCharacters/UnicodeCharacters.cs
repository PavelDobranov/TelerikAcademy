// Problem 10. Unicode characters
// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = ConvertToUnicodeCharacters(input);

        Console.WriteLine("Result: {0}", result);
    }

    static string ConvertToUnicodeCharacters(string input)
    {
        StringBuilder result = new StringBuilder();

        foreach (int character in input)
        {
            string unicodeChar = string.Format("\\u{0:x4}", character);

            result.Append(unicodeChar);
        }

        return result.ToString();
    }
}