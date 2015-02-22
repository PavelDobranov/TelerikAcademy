// Problem 6. binary to hexadecimal
// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Number(2) = ");
        string number = Console.ReadLine();
        number = number.ToUpper();

        Console.WriteLine("Number(16) = {0}", CovertBinaryToHexadecimal(number));
    }

    static string CovertBinaryToHexadecimal(string number)
    {
        int length = number.Length;
        int subDigitsCount = 4;

        if (length % subDigitsCount != 0)
        {
            int zeroesCount = subDigitsCount - (length % subDigitsCount);
            number = new string('0', zeroesCount) + number;
        }

        Queue<char> digits = new Queue<char>();

        string subBits;

        for (int bit = 0; bit < length; bit += 4)
        {
            subBits = number.Substring(bit, 4);

            switch (subBits)
            {
                case "0000": digits.Enqueue('0'); break;
                case "0001": digits.Enqueue('1'); break;
                case "0010": digits.Enqueue('2'); break;
                case "0011": digits.Enqueue('3'); break;
                case "0100": digits.Enqueue('4'); break;
                case "0101": digits.Enqueue('5'); break;
                case "0110": digits.Enqueue('6'); break;
                case "0111": digits.Enqueue('7'); break;
                case "1000": digits.Enqueue('8'); break;
                case "1001": digits.Enqueue('9'); break;
                case "1010": digits.Enqueue('A'); break;
                case "1011": digits.Enqueue('B'); break;
                case "1100": digits.Enqueue('C'); break;
                case "1101": digits.Enqueue('D'); break;
                case "1110": digits.Enqueue('E'); break;
                case "1111": digits.Enqueue('F'); break;
            }
        }

        return string.Join("", digits);
    }
}