// Problem 10. Odd and Even Product
// You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal
// to the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

public class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter numbers in a single line, separated by a space: ");
        string numbersLine = Console.ReadLine();
        string[] numbers = numbersLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int oddProduct = 1;
        int evenProduct = 1;
        int currentNumber;

        for (int numberPosition = 1; numberPosition <= numbers.Length; numberPosition++)
        {
            currentNumber = int.Parse(numbers[numberPosition - 1]);

            if (numberPosition % 2 == 0)
            {
                evenProduct *= currentNumber;
            }
            else if (numberPosition % 2 != 0)
            {
                oddProduct *= currentNumber;
            }
        }

        Console.WriteLine("Result: {0}", evenProduct == oddProduct ? "yes" : "no");
        Console.WriteLine("Odd product = {0}", oddProduct);
        Console.WriteLine("Even product = {0}", evenProduct);
    }
}