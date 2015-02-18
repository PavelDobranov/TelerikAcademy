// Problem 12. Index of letters
// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        Console.Write("Type a word: ");
        string inputWord = Console.ReadLine();

        Console.Write("Result: ");
        PrintIndexOfLetters(inputWord);
    }

    static void PrintIndexOfLetters(string word)
    {
        word = word.ToUpper();

        char asciiLetterA = 'A';

        for (int letter = 0; letter < word.Length; letter++)
        {
            int letterAlphabetIndex = word[letter] - asciiLetterA + 1;

            Console.Write("{0} ", letterAlphabetIndex);
        }

        Console.WriteLine();
    }
}