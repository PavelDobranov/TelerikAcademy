// Problem 13. Solve tasks
// Write a program that can solve these tasks:
//  - Reverses the digits of a number
//  - Calculates the average of a sequence of integers
//  - Solves a linear equation a * x + b = 0
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
//   - The decimal number should be non-negative
//   - The sequence should not be empty
//   - a should not be equal to 0

using System;

class SloveTasks
{
    static void Main()
    {
        Console.WriteLine("MENU:");
        Console.WriteLine("Press [1] -> Reverses the digits of a number");
        Console.WriteLine("Press [2] -> Calculates the average of a sequence of integers");
        Console.WriteLine("Press [3] -> Solves a linear equation a * x + b = 0");
        Console.Write("Choose: ");

        int menuInput = int.Parse(Console.ReadLine());

        if (menuInput == 1)
        {
            ReverseDigits();
        }
        else if (menuInput == 2)
        {
            CalculateАverageSum();
        }
        else if (menuInput == 3)
        {
            SolveLinearEquation();
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }

    static void ReverseDigits()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            int result = 0;

            while (number > 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }

            Console.WriteLine("Result: {0}", result);
        }
        else
        {
            Console.WriteLine("The number cannot be negative!");
        }

    }

    static void CalculateАverageSum()
    {
        Console.WriteLine("Enter 'end' to stop");
        string input;

        double sum = 0;
        int numbersCount = 0;

        while (true)
        {
            Console.Write("Number[{0}] ", numbersCount + 1);
            input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            sum += int.Parse(input);
            numbersCount++;
        }

        if (numbersCount != 0)
        {
            Console.WriteLine("Result: {0}", sum / numbersCount);
        }
        else
        {
            Console.WriteLine("The sequence cannot not be empty!");
        }
    }

    static void SolveLinearEquation()
    {
        Console.Write("a = ");
        double aCoefficient = double.Parse(Console.ReadLine());

        if (aCoefficient != 0)
        {
            Console.Write("b = ");
            double bCoefficient = double.Parse(Console.ReadLine());

            double x = bCoefficient / aCoefficient;

            Console.WriteLine("a * x + b = 0");
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            Console.WriteLine("Input 'a' cannot be zero!");
        }
    }
}