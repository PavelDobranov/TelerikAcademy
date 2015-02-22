// Problem 4. Hexadecimal to decimal
// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Number(16) = ");
        string number = Console.ReadLine();
        number = number.ToUpper();

        Console.WriteLine("Number(10) = {0}", ConvertHexadecimalToDecimal(number));
    }

    static long ConvertHexadecimalToDecimal(string number)
    {
        long exponent = 1;
        int hexBase = 16;
        long result = 0;
        int digit;

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