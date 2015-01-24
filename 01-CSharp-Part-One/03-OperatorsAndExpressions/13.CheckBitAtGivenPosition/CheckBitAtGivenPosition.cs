// Problem 13. Check a Bit at Given Position
// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
// in given integer number n, has value of 1.

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter an integer value: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        string numberBinaryRepresentation = GetNumberBinaryRepresentation(number);

        bool result = GetBitAtGivenPosition(number, bitPosition) == 1;

        Console.WriteLine("Binary representation: {0}", numberBinaryRepresentation);
        Console.WriteLine("Bit position: {0}", bitPosition);
        Console.WriteLine("Bit at position #{0} == 1: {1}", bitPosition, result);
    }

    static string GetNumberBinaryRepresentation(int number)
    {
        string numberBinaryRepresentation = Convert.ToString(number, 2).PadLeft(16, '0');

        return numberBinaryRepresentation;
    }

    static int GetBitAtGivenPosition(int number, int bitPosition)
    {
        return (number & 1 << bitPosition) >> bitPosition;
    }
}