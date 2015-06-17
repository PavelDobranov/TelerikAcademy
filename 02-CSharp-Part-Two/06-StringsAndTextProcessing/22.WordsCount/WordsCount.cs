// Problem 22. Words count
// Write a program that reads a string from the console and lists all different words in the string along with
// information how many times each word is found.

using System;

class WordsCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Result: ");
        CountWords(input);
    }

    static void CountWords(string input)
    {
        char[] separators = { ' ', '.', ',', '!', '?' };
        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        int firstIndex = 0;

        while (firstIndex < words.Length)
        {
            int lastIndex = Array.LastIndexOf(words, words[firstIndex]);

            int count = (lastIndex - firstIndex) + 1;

            Console.WriteLine("{0} - {1}", words[firstIndex], count);

            firstIndex = lastIndex + 1;
        }
    }
}