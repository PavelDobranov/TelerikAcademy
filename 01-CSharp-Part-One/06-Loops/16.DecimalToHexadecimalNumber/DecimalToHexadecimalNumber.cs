// Problem 16. Decimal to Hexadecimal Number
// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;
using System.Collections.Generic;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine("Hexadecimal representation: {0}", DecimalToHexadecimal(number));
    }

    static string DecimalToHexadecimal(long number)
    {
        if (number == 0)
        {
            return "0";
        }

        Stack<char> digitsCollector = new Stack<char>();

        int hexBase = 16;

        while (number != 0)
        {
            long digit = number % hexBase;

            switch (digit)
            {
                case 10: digitsCollector.Push('A'); break;
                case 11: digitsCollector.Push('B'); break;
                case 12: digitsCollector.Push('C'); break;
                case 13: digitsCollector.Push('D'); break;
                case 14: digitsCollector.Push('E'); break;
                case 15: digitsCollector.Push('F'); break;
                default: digitsCollector.Push(digit.ToString()[0]); break;
            }

            number /= hexBase;
        }

        return string.Join("", digitsCollector);
    }
}
