// Problem 9.* Binary floating-point
// Write a program that shows the internal binary representation of given 32-bit signed floating-point
// number in IEEE 754 format (the C# type float).

using System;

class FloatingPointToBinary
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        float number = float.Parse(Console.ReadLine());

        PrintFloatingPointToBinary(number);
    }

    static void PrintFloatingPointToBinary(float number)
    {
        byte[] byteArray = GetBytesSingle(number);

        int intBits = BitConverter.ToInt32(byteArray, 0);

        int binBase = 2;
        int bitsCount = 32;

        string internalBinary = Convert.ToString(intBits, binBase);
        internalBinary = internalBinary.PadLeft(bitsCount, '0');

        int signStartPosition = 0;
        int signLength = 1;
        string sign = internalBinary.Substring(signStartPosition, signLength);

        int exponentStartPosition = 1;
        int exponentLength = 8;
        string exponent = internalBinary.Substring(exponentStartPosition, exponentLength);

        int mantissaStartPosition = 9;
        int mantissaLength = 23;
        string mantissa = internalBinary.Substring(mantissaStartPosition, mantissaLength);

        Console.WriteLine("Sign = {0}", sign);
        Console.WriteLine("Exponent = {0}", exponent);
        Console.WriteLine("Mantissa = {0}", mantissa);
    }

    static byte[] GetBytesSingle(float number)
    {
        byte[] floatToByteArray = BitConverter.GetBytes(number);
        return floatToByteArray;
    }
}