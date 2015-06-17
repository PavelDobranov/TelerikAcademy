// Problem 2. Reverse string
// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string input = Console.ReadLine();

        string result = ReverseText(input);

        Console.WriteLine("Result: {0}", result);
    }

    static string ReverseText(string input)
    {
        StringBuilder reversed = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }
}