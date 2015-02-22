// Problem 3. Decimal to hexadecimal
// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Number(10) = ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Hexadecimal representation: {0}", ConvertDecimalToHexadecimal(number));
    }

    static string ConvertDecimalToHexadecimal(int number) 
    {
        if (number == 0)
        {
            return "0";
        }

        Stack<char> digits = new Stack<char>();
        
        int hexBase = 16;
        int digit;

        while (number != 0)
        {
            digit = number % hexBase;

            switch (digit)
            {
                case 10: digits.Push('A'); break; 
                case 11: digits.Push('B'); break; 
                case 12: digits.Push('C'); break;                     
                case 13: digits.Push('D'); break;                     
                case 14: digits.Push('E'); break;                     
                case 15: digits.Push('F'); break;                     
                default: digits.Push(digit.ToString()[0]); break;                    
            }

            number /= hexBase;
        }

        return string.Join("", digits);
    }
}