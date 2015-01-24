// Problem 16.** Bit Exchange (Advanced)
// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a 
// given 32-bit unsigned integer.
// The first and the second sequence of bits may not overlap.

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter a positive integer value [n]: ");
        long number = long.Parse(Console.ReadLine());

        Console.Write("Enter first group start position [p]: ");
        int firtsGroupStartIndex = int.Parse(Console.ReadLine());

        Console.Write("Enter second group start position [q]: ");
        int secondGroupStartIndex = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of bits that will be exchanged [k]: ");
        int groupsLenght = int.Parse(Console.ReadLine());

        int shift = secondGroupStartIndex - firtsGroupStartIndex;

        string numberBinaryRepresentation = GetNumberBinaryRepresentation(number);
        Console.WriteLine("Number binary representation: {0}", numberBinaryRepresentation);

        if (firtsGroupStartIndex < 0 || secondGroupStartIndex < 0 || firtsGroupStartIndex + groupsLenght > 32 || secondGroupStartIndex + groupsLenght > 32)
        {
            Console.WriteLine("Result binary representation: - ");
            Console.WriteLine("out of range");
        }
        else if (Math.Abs(shift) < groupsLenght)
        {
            Console.WriteLine("Result binary representation: - ");
            Console.WriteLine("overlapping");
        }
        else
        {
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
            
            Console.WriteLine("Result binary representation: {0}", resultNumberBinaryRepresentation);
            Console.WriteLine("Result {0}", number);
        }
    }

    static string GetNumberBinaryRepresentation(long number)
    {
        string numberBinaryRepresentation = Convert.ToString(number, 2).PadLeft(32, '0');

        return numberBinaryRepresentation;
    }

    static int GetBitAtGivenPosition(long number, int bitPosition)
    {
        return (int)(number & 1 << bitPosition) >> bitPosition;
    }

    static long ModifyBitAtGivenPosition(long number, int bitPosition, int bitNewValue)
    {
        number = bitNewValue == 0 ? (long)(number & ~(1 << bitPosition)) : (long)(number | (1 << bitPosition));

        return number;
    }
}