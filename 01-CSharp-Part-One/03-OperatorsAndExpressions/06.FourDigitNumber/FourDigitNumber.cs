// Problem 6. Four-Digit Number
// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) 
// and performs the following:
//  - Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//  - Prints on the console the number in reversed order: dcba (in our example 1102).
//  - Puts the last digit in the first position: dabc (in our example 1201).
//  - Exchanges the second and the third digits: acbd (in our example 2101).

using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = 2011;

        int sumOfDigits = CalculateSumOfTheDigits(number);
        Console.WriteLine("Sum of digits: {0}", sumOfDigits);

        int reversedNumber = ReverseDigits(number);
        Console.WriteLine("Reversed: {0}", reversedNumber);

        int lastDigitInFront = PutLastDigitInFront(number);
        Console.WriteLine("Last digit in front: {0}", lastDigitInFront);


    }

    static int CalculateSumOfTheDigits(int number)
    {
        int result = 0;

        while (number > 0)
        {
            result += number % 10;
            number /= 10;
        }

        return result;
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

    static int PutLastDigitInFront(int number)
    {
        int result = number % 10 * 1000;

        result += number / 10;

        return result;
    }
}