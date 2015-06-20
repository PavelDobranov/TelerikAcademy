// Problem 1. Exchange If Greater
// Write an if-statement that takes two double variables a and b and exchanges 
// their values if the first one is greater than the second one.
// As a result print the values a and b, separated by a space.

using System;

public class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            ExchangeVariables(ref firstNumber, ref secondNumber);
        }

        Console.WriteLine("{0} {1}", firstNumber, secondNumber);
    }

    private static void ExchangeVariables(ref double firstNumber, ref double secondNumber)
    {
        firstNumber += secondNumber;
        secondNumber = firstNumber - secondNumber;
        firstNumber -= secondNumber;
    }
}