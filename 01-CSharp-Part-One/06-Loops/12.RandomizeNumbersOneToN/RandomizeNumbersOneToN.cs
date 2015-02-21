// Problem 12.* Randomize the Numbers 1…N
// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeNumbersOneToN
{
    static void Main()
    {
        Console.Write("Enter number [n]: ");
        int numberN = int.Parse(Console.ReadLine());

        bool[] printed = new bool[numberN];
        int printedNumbersCount = 0;

        Random randomNumberGenerator = new Random();

        int currentNumber;

        while (printedNumbersCount != numberN)
        {
            currentNumber = randomNumberGenerator.Next(1, numberN + 1);

            if (!printed[currentNumber - 1])
            {
                Console.Write("{0} ", currentNumber);
                printed[currentNumber - 1] = true;
                printedNumbersCount++;
            }
        }

        Console.WriteLine();
    }
}