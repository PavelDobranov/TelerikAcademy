// Problem 8. Digit as Word
// Write a program that asks for a digit (0-9), and depending on the input, 
// shows the digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.

using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Enter a digit in interval [0 - 9]: ");
        int digit = int.Parse(Console.ReadLine());

        if (digit < 0 || digit > 9)
        {
            Console.WriteLine("not a digit");
        }
        else
        {
            string digitAsWord = GetDigitAsWord(digit);

            Console.WriteLine("Result: {0}", digitAsWord);
        }
    }

    static string GetDigitAsWord(int digit)
    {
        string digitAsWord = "";

        switch (digit)
        {
            case 0: digitAsWord = "zero"; break;
            case 1: digitAsWord = "one"; break;
            case 2: digitAsWord = "two"; break;
            case 3: digitAsWord = "three"; break;
            case 4: digitAsWord = "four"; break;
            case 5: digitAsWord = "five"; break;
            case 6: digitAsWord = "six"; break;
            case 7: digitAsWord = "seven"; break;
            case 8: digitAsWord = "eight"; break;
            case 9: digitAsWord = "nine"; break;
        }

        return digitAsWord;
    }
}