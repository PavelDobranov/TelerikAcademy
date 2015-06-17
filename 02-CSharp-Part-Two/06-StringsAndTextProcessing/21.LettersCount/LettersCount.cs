// Problem 21. Letters count
// Write a program that reads a string from the console and prints all different letters in the 
// string along with information how many times each letter is found.

using System;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Result: ");
        CountLetters(input);
    }

    static void CountLetters(string input)
    {
        input = input.Replace(" ", string.Empty);

        char[] letters = input.ToCharArray();

        Array.Sort(letters);

        int firstIndex = 0;

        while (firstIndex < letters.Length)
        {
            int lastIndex = Array.LastIndexOf(letters, letters[firstIndex]);

            int count = (lastIndex - firstIndex) + 1;

            Console.WriteLine("{0} - {1}", letters[firstIndex], count);

            firstIndex = lastIndex + 1;
        }
    }
}