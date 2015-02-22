// Write a program that shows the binary representation 
// of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;

class ShortToBinaryRepresentation
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        short number = short.Parse(Console.ReadLine());

        string result = ShortToBinary(number);
        Console.WriteLine("Number(2) = {0}", result);
    }

    static string ShortToBinary(short number)
    {
        bool isNegative = false;

        if (number < 0)
        {
            number = (short)~number; // for example ---> (-3 = 2)
            isNegative = true;
        }

        List<int> bits = new List<int>();

        int bitsCount = 16;
        int binBase = 2;

        for (int counter = 0; counter < bitsCount; counter++)
        {
            bits.Add(number % binBase);
            number /= (short)binBase;
        }

        if (isNegative)
        {
            ReverseBitValues(bits);
        }

        bits.Reverse();

        return string.Join("", bits);
    }

    static void ReverseBitValues(List<int> bits)
    {
        for (int bit = 0; bit < bits.Count; bit++)
        {
            if (bits[bit] == 0)
            {
                bits[bit] = 1;
            }
            else
            {
                bits[bit] = 0;
            }
        }
    }
}