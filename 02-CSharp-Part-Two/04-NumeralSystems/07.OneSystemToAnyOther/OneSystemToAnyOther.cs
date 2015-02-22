// Problem 7. One system to any other
// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Number = ");
        string number = Console.ReadLine();
        number = number.ToUpper();

        Console.Write("Numeral system input: ");
        int inputNumSystem = int.Parse(Console.ReadLine());

        Console.Write("Numeral system output: ");
        int outputNumSystem = int.Parse(Console.ReadLine());

        if (number == "0")
        {
            Console.WriteLine("Number({0}) = 0", outputNumSystem);
        }
        else
        {
            if (inputNumSystem == 10)
            {
                Console.WriteLine("Number({0}) = {1}", outputNumSystem, DecimalToXBase(number, outputNumSystem));
            }
            else
            {
                string decimlTemp = XBaseToDecimal(number, inputNumSystem);

                Console.WriteLine("Number({0}) = {1}", outputNumSystem, DecimalToXBase(decimlTemp, outputNumSystem));
            }
        }
    }

    static string XBaseToDecimal(string number, int inputBase)
    {
        int exponent = 1;
        int result = 0;
        int digit;

        for (int position = number.Length - 1; position >= 0; position--)
        {
            switch (number[position])
            {
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
                default: digit = (int)(number[position] - '0'); break;
            }

            result += digit * exponent;
            exponent *= inputBase;
        }

        return result.ToString();
    }

    static string DecimalToXBase(string number, int outputBase)
    {
        int decNumber = int.Parse(number);

        Stack<int> result = new Stack<int>();

        while (decNumber != 0)
        {
            result.Push(decNumber % outputBase);
            decNumber /= outputBase;
        }

        return string.Join("", result);
    }
}