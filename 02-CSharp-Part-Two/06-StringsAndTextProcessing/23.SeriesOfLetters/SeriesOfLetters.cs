// Problem 23. Series of letters
// Write a program that reads a string from the console and replaces all series of consecutive 
// identical letters with a single one.

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = RemoveSeriesOfLetters(input);
        Console.WriteLine("Result: {0}", result);
    }

    static string RemoveSeriesOfLetters(string input)
    {
        input = input.Replace(" ", "");

        StringBuilder result = new StringBuilder();

        int index = 1;

        result.Append(input[index - 1]);

        while (index < input.Length)
        {
            if (input[index] != input[index - 1])
            {
                result.Append(input[index]);
            }

            index++;
        }

        return result.ToString();
    }
}
