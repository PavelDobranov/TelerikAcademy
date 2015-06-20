// Problem 12. Extract Bit from Integer
// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

public class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter an integer value: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        string numberBinaryRepresentation = GetNumberBinaryRepresentation(number);

        int bit = GetBitAtGivenPosition(number, bitPosition);

        Console.WriteLine("Binary representation: {0}", numberBinaryRepresentation);
        Console.WriteLine("Bit position: {0}", bitPosition);
        Console.WriteLine("Bit at position #{0}: {1}", bitPosition, bit);
    }

    private static string GetNumberBinaryRepresentation(int number)
    {
        string numberBinaryRepresentation = Convert.ToString(number, 2).PadLeft(16, '0');

        return numberBinaryRepresentation;
    }

    private static int GetBitAtGivenPosition(int number, int bitPosition)
    {
        return (number & 1 << bitPosition) >> bitPosition;
    }
}