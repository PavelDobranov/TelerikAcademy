// Problem 3. English digit
// Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        string result = GetLastDigitAsWord(inputNumber);
        
        Console.WriteLine("Result: {0}", result);
    }

    static string GetLastDigitAsWord(int number)
    {
        string[] englishDigits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        return englishDigits[number % 10];
    }
}