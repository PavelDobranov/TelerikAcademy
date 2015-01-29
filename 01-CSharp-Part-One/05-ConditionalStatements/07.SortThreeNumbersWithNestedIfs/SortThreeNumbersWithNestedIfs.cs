//Problem 7. Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        string sortedNumbers = SortNumbersWithNestedIfs(firstNumber, secondNumber, thirdNumber);

        Console.WriteLine("Sorted numbers: {0}", sortedNumbers);
    }

    static string SortNumbersWithNestedIfs(double firstNumber, double secondNumber, double thirdNumber)
    {
        string formatedString = "{0}, {1}, {2}";

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                return string.Format(formatedString, firstNumber, secondNumber, thirdNumber); 
            }
            else
            {
                return string.Format(formatedString, firstNumber, thirdNumber, secondNumber);
            }
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                return string.Format(formatedString, secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                return string.Format(formatedString, secondNumber, thirdNumber, firstNumber);
            }
        }
        else
        {
            if (firstNumber > secondNumber)
            {
                return string.Format(formatedString, thirdNumber, firstNumber, secondNumber);
            }
            else
            {
                return string.Format(formatedString, thirdNumber, secondNumber, firstNumber);
            }
        }
    }
}