// Problem 3. Divide by 7 and 5
// Write a Boolean expression that checks for given integer if it can be divided 
// (without remainder) by 7 and 5 at the same time.

using System;
public class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter an integer value: ");
        int number = int.Parse(Console.ReadLine());

        int divider = 7 * 5;

        bool result = number % divider == 0;

        Console.WriteLine("Divided by 7 and 5? : {0}", result);
    }
}