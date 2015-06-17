// Problem 1. Square root
// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print Invalid number.
// In all cases finally print Good bye.
// Use try-catch-finally block.

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a positive number: ");
            uint number = uint.Parse(Console.ReadLine());

            double result = Math.Sqrt(number);

            Console.WriteLine("Square Root: {0}", result);
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good Bye!");
        }
    }
}