// Problem 14. Decimal to Binary Number
// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;
using System.Collections.Generic;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation: {0}", DecimalToBinary(number));
    }

    static string DecimalToBinary(int number)
    {
        if (number == 0)
        {
            return "0";
        }

        Stack<int> digitsCollector = new Stack<int>();

        int binBase = 2;

        while (number != 0)
        {
            digitsCollector.Push(number % binBase);
            number /= binBase;
        }

        return string.Join("", digitsCollector);
    }
}