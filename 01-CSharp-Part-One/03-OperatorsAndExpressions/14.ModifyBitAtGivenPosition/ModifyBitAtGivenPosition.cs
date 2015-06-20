// Problem 14. Modify a Bit at Given Position
// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
// at the position p from the binary representation of n while preserving all other bits in n.

using System;

public class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter an integer value: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit value [0 or 1]: ");
        int bitValue = int.Parse(Console.ReadLine());

        string numberBinaryRepresentation = GetNumberBinaryRepresentation(number);

        int result = ModifyBit(number, bitPosition, bitValue);

        string resultBinaryRepresentation = GetNumberBinaryRepresentation(number);

        Console.WriteLine("Number binary representation: {0}", numberBinaryRepresentation);
        Console.WriteLine("Bit position: #{0}", bitPosition);
        Console.WriteLine("Bit value: {0}", bitValue);
        Console.WriteLine("Result binary representation: {0}", resultBinaryRepresentation);
        Console.WriteLine("Result {0}", result);
    }

    private static string GetNumberBinaryRepresentation(int number)
    {
        string numberBinaryRepresentation = Convert.ToString(number, 2).PadLeft(16, '0');

        return numberBinaryRepresentation;
    }

    private static int ModifyBit(int number, int bitPosition, int bitNewValue)
    {
        number = bitNewValue == 0 ? number & ~(1 << bitPosition) : number | (1 << bitPosition);

        return number;
    }
}