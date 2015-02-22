// Problem 2. Binary to decimal
// Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Number(2) = ");
        string inputNumber = Console.ReadLine();

        Console.WriteLine("Number(10) = {0}", ConvertBinaryToDecimal(inputNumber));
    }

    static int ConvertBinaryToDecimal(string number)
    {
        int exponent = 1;
        int binBase = 2;
        int result = 0;

        for (int bit = number.Length - 1; bit >= 0; bit--)
        {
            if (number[bit] == '1')
            {
                result += exponent;
            }

            exponent *= binBase;
        }

        return result;
    }
}