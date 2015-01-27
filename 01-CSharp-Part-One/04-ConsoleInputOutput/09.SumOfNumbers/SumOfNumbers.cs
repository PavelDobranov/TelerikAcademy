// Problem 9. Sum of n Numbers
// Write a program that enters a number n and after that enters more n numbers 
// and calculates and prints their sum.

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int numbersCount = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int number = 1; number <= numbersCount; number++)
        {
            Console.Write("Enter number [{0}]: ", number);
            sum += int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}