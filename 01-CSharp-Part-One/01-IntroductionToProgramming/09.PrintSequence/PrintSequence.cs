// Problem 9. Print a Sequence
// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintSequence
{
    static void Main()
    {
        int numbersCount = 10;
        int startNumber = 2;

        for (int number = startNumber; number < numbersCount + startNumber; number++)
        {
            if (number % 2 == 0)
            {
                Console.Write("{0} ", number);
            }
            else
            {
                Console.Write("{0} ", -number);
            }
        }

        Console.WriteLine();
    }
}