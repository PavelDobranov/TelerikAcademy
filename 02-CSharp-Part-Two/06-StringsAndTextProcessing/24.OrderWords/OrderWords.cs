// Problem 24. Order words
// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main()
    {
        string input = "Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order";

        Console.WriteLine("Result: ");
        PrintOrderedWords(input);
    }

    static void PrintOrderedWords(string input)
    {
        char[] separators = { ' ' };
        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}