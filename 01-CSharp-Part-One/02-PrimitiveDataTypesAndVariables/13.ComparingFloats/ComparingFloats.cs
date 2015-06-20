// Problem 13.* Comparing Floats
// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
// Note: Two floating-point numbers a and b cannot be compared directly by a == b because of 
// the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal 
// if they are more closely to each other than a fixed constant eps.

using System;

public class ComparingFloats
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Result: ");
        Console.WriteLine(SafelyCompare(firstNumber, secondNumber));
    }

    private static bool SafelyCompare(double firstNumber, double secondNumber)
    {
        double precision = 0.000001;

        return Math.Abs(firstNumber - secondNumber) < precision ? true : false;
    }
}