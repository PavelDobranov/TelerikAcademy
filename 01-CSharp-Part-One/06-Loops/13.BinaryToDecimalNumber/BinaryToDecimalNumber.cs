// Problem 13. Binary to Decimal Number
// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter number in binary representation: ");
        string binaryNumber = Console.ReadLine();

        Console.WriteLine("Decimal representation: {0}", BinaryToDecimal(binaryNumber));
    }

    static int BinaryToDecimal(string number)
    {
        int exponent = 1;
        int binBase = 2;
        int result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (number[i] == '1')
            {
                result += exponent;
            }

            exponent *= binBase;
        }

        return result;
    }
}