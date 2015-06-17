// Problem 11. Format number
// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
// Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Result: ");
        PrintFormatedNumber(number);
    }

    static void PrintFormatedNumber(int number)
    {
        Console.WriteLine("{0,15:d} -> Decimal", number);
        Console.WriteLine("{0,15:X4} -> Hexadecimal", number);
        Console.WriteLine("{0,15:p} -> Percent", number);
        Console.WriteLine("{0,15:e} -> Scientific", number);
    }
}