// Problem 5. Formatting Numbers
﻿// Write a program that reads 3 numbers:
//  - integer a (0 <= a <= 500)
//  - floating-point b
//  - floating-point c
// The program then prints them in 4 virtual columns on the console. 
// Each column should have a width of 10 characters.
//  - The number a should be printed in hexadecimal, left aligned
//  - Then the number a should be printed in binary form, padded with zeroes
//  - The number b should be printed with 2 digits after the decimal point, right aligned
//  - The number c should be printed with 3 digits after the decimal point, left aligned.

using System;

public class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter the fist number [0 <= a <= 500]: ");
        int firstNumber = int.Parse(Console.ReadLine());

        if (firstNumber < 0 || firstNumber > 500)
        {
            Console.WriteLine("The number is out of range [0 <= a <= 500]");
            return;
        }

        Console.Write("Enter the second number [b]: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the third number [c]: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        int columnWidth = 10;

        Console.WriteLine("|{0}|{1}|{2}|{3}|",
            firstNumber.ToString("X").PadRight(columnWidth, ' '),
            Convert.ToString(firstNumber, 2).PadLeft(columnWidth, '0'),
            secondNumber.ToString("0.00").PadLeft(columnWidth, ' '),
            thirdNumber.ToString("0.000").PadRight(columnWidth, ' '));
    }
}