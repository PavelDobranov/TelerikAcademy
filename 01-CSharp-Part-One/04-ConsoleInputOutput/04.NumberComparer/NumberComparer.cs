// Problem 4. Number Comparer
// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double greaterNumber = firstNumber > secondNumber ? firstNumber : secondNumber;

        Console.WriteLine("Greater number: {0}", greaterNumber);
    }
}