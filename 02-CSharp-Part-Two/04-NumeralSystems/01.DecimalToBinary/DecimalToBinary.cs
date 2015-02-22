// Problem 1. Decimal to binary
// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Number(10) = ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Number(2): {0}", ConvertDecimalToBinary(number));
    }

    static string ConvertDecimalToBinary(int number)
    {
        if (number == 0)
        {
            return "0";
        }

        Stack<int> bits = new Stack<int>();

        int binBase = 2;

        while (number != 0)
        {
            bits.Push(number % binBase);
            number /= binBase;
        }

        return string.Join("", bits);
    }
}