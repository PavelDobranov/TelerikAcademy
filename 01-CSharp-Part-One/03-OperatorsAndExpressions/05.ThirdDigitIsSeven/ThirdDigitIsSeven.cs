// Problem 5. Third Digit is 7?
// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter an integer value: ");
        int number = int.Parse(Console.ReadLine());

        int digitValue = 7;

        bool isSeven = (number / 100) % 10 == digitValue;

        Console.WriteLine("Third digit {0}? : {1}", digitValue, isSeven);
    }
}