// Problem 7. Calculate N! / (K! * (N-K)!)
// In combinatorics, the number of ways to choose k different members out of a group of n different
// elements (also known as the number of combinations) is calculated by the following formula:
// formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
// Try to use only two loops.

using System;
using System.Numerics;

class FactorialCalculations
{
    static void Main()
    {
        Console.Write("Enter number [n] [1 < n < 100]: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("Enter number [k] [1 < k < n]: ");
        int numberK = int.Parse(Console.ReadLine());

        if (1 < numberK && numberK < numberN && numberN < 100)
        {
            BigInteger numerator = 1;
            BigInteger divider = 1;

            for (int i = numberK + 1; i <= numberN; i++)
            {
                numerator *= i;
            }

            for (int i = 1; i <= (numberN - numberK); i++)
            {
                divider *= i;
            }

            BigInteger result = numerator / divider;

            Console.WriteLine("n! / k!(n - k)! = {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}