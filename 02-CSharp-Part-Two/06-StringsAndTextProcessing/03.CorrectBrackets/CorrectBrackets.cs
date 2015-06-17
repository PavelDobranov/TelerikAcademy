// Problem 3. Correct brackets
// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string input = Console.ReadLine();

        Console.WriteLine("Correct brackets? : {0}", CheckBrackets(input));
    }

    static bool CheckBrackets(string expression)
    {
        int counter = 0;

        foreach (char token in expression)
        {
            if (token == '(')
            {
                counter++;
            }
            else if (token == ')')
            {
                counter--;
            }

            if (counter < 0)
            {
                return false;
            }
        }

        return counter == 0;
    }
}