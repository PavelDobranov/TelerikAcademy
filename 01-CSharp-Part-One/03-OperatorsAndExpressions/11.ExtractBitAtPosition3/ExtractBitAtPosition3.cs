// Problem 11. Bitwise: Extract Bit #3
// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

using System;

public class ExtractBitAtPosition3
{
    static void Main()
    {
        Console.Write("Enter a positive integer value: ");
        uint number = uint.Parse(Console.ReadLine());

        int bitPosition = 3;

        string numberBinaryRepresentation = GetNumberBinaryRepresentation(number);

        int bit = GetBitAtGivenPosition(number, bitPosition);

        Console.WriteLine("Binary representation: {0}", numberBinaryRepresentation);
        Console.WriteLine("Bit at position #{0}: {1}", bitPosition, bit);
    }

    private static string GetNumberBinaryRepresentation(uint number)
    {
        string numberBinaryRepresentation = Convert.ToString(number, 2).PadLeft(16, '0');

        return numberBinaryRepresentation;
    }

    private static int GetBitAtGivenPosition(uint number, int bitPosition)
    {
        return ((int)number & 1 << bitPosition) >> bitPosition;
    }
}