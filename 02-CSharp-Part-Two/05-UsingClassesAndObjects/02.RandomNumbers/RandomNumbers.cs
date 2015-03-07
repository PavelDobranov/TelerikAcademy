// Problem 2. Random numbers
// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        int numbersCount = 10;
        int rangeMin = 100;
        int rangeMax = 200;

        PrintRandomNumbers(numbersCount, rangeMin, rangeMax);
    }

    static void PrintRandomNumbers(int numbersCount, int rangeMin, int rangeMax)
    {
        Random randomGenerator = new Random();

        for (int number = 0; number < numbersCount; number++)
        {
            Console.WriteLine(randomGenerator.Next(rangeMin, rangeMax + 1));
        }
    }
}