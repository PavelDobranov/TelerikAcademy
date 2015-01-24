// Problem 15.* Bits Exchange
// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter a positive integer value: ");
        uint number = uint.Parse(Console.ReadLine());

        int firtsGroupStartIndex = 3;
        int secondGroupStartIndex = 24;
        int groupsLenght = 3;
        int shift = secondGroupStartIndex - firtsGroupStartIndex;

        string numberBinaryRepresentation = GetNumberBinaryRepresentation(number);

        for (int i = firtsGroupStartIndex; i < firtsGroupStartIndex + groupsLenght; i++)
        {
            int firtsBitPosition = i;
            int secondBitPossition = i + shift;
            
            int firstBitValue = GetBitAtGivenPosition(number, firtsBitPosition);
            int secondBitValue = GetBitAtGivenPosition(number, secondBitPossition);

            number = ModifyBitAtGivenPosition(number, firtsBitPosition, secondBitValue);
            number = ModifyBitAtGivenPosition(number, secondBitPossition, firstBitValue);
        }

        string resultNumberBinaryRepresentation = GetNumberBinaryRepresentation(number);

        Console.WriteLine("Number binary representation: {0}", numberBinaryRepresentation);
        Console.WriteLine("Result binary representation: {0}", resultNumberBinaryRepresentation);
        Console.WriteLine("Result {0}", number);
    }

    static string GetNumberBinaryRepresentation(uint number)
    {
        string numberBinaryRepresentation = Convert.ToString(number, 2).PadLeft(32, '0');

        return numberBinaryRepresentation;
    }

    static int GetBitAtGivenPosition(uint number, int bitPosition)
    {
        return (int)(number & 1 << bitPosition) >> bitPosition;
    }

    static uint ModifyBitAtGivenPosition(uint number, int bitPosition, int bitNewValue)
    {        
        number = bitNewValue == 0 ? (uint)(number & ~(1 << bitPosition)) : (uint)(number | (1 << bitPosition));

        return number;
    }
}