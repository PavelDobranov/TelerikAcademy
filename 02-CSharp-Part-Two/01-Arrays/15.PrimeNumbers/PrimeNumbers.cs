// Problem 15. Prime numbers
// Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        int maxRange = 10000000;
        bool[] numbers = new bool[maxRange];

        Console.WriteLine("Result: ");
        PrintPrimeNumbers(maxRange, numbers);
    }

    static void PrintPrimeNumbers(int maxRange, bool[] primes)
    {
        for (int number = 2; number < Math.Sqrt(maxRange); number++)
        {
            if (!primes[number])
            {
                for (int j = number * number; j < primes.Length; j += number)
                {
                    primes[j] = true;
                }
            }
        }

        for (int number = 2; number < primes.Length; number++)
        {
            if (!primes[number])
            {
                Console.Write("{0} ", number);
            }
        }

        Console.WriteLine();
    }
}