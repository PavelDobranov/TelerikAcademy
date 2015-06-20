// Problem 4. Multiplication Sign
// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

using System;

public class MultiplicationSign
{
    static void Main()
    {
        int numbersCount = 3;
        bool isNegativeProduct = false;
        bool isZeroProduct = false;
        char result = ' ';
        double number;

        for (int i = 0; i < numbersCount; i++)
        {
            Console.Write("Enter number [{0}]: ", (char)('a' + i));
            number = double.Parse(Console.ReadLine());

            if (number == 0)
            {
                result = '0';
                isZeroProduct = true;
            }

            if (number < 0 && !isZeroProduct)
            {
                isNegativeProduct = !isNegativeProduct;
            }

            result = isNegativeProduct ? '-' : '+';
        }

        Console.WriteLine("Result: {0}", result);
    }
}