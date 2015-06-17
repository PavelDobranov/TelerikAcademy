// Problem 6. String length
// Write a program that reads from the console a string of maximum 20 characters.
// If the length of the string is less than 20, the rest of the characters should be filled with *.
// Print the result string into the console.

using System;

class StringLength
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int maxLength = 20;

        if (input.Length > maxLength)
        {
            Console.WriteLine("String length must be equal or less than {0} characters", maxLength);
        }
        else
        {
            Console.WriteLine("Result: {0}", input.PadRight(maxLength, '*'));
        }
    }
}