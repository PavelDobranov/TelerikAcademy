// Problem 15. Hexadecimal to Decimal Number
// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter number in hexadecimal representation: ");
        string hexNumber = Console.ReadLine();
        hexNumber = hexNumber.ToUpper();

        Console.WriteLine("Decimal representation: {0}", HexadecimalToDecimal(hexNumber));
    }

    static long HexadecimalToDecimal(string number)
    {
        long exponent = 1;
        int hexBase = 16;
        long result = 0;
        int digit = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            switch (number[i])
            {
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
                default: digit = (int)(number[i] - '0'); break;
            }

            result += digit * exponent;
            exponent *= hexBase;
        }

        return result;
    }
}