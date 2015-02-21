// Problem 7. Reverse number
// Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseDigits(number);

        Console.WriteLine("Result: {0}", reversedNumber);
    }

    static int ReverseDigits(int number)
    {
        int result = 0;

        while (number > 0)
        {
            result = result * 10 + number % 10;
            number /= 10;
        }

        return result;
    }
}