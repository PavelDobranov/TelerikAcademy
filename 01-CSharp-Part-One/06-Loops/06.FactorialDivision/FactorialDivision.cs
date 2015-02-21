// Problem 6. Calculate N! / K!
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop

using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        Console.Write("Enter number [n] [1 < n < 100]: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("Enter number [k] [1 < k < n]: ");
        int numberK = int.Parse(Console.ReadLine());

        if (1 < numberK && numberK < numberN && numberN < 100)
        {
            BigInteger result = 1;

            for (int i = numberN; i > numberK; i--)
            {
                result *= i;
            }

            Console.WriteLine("n!/k! = {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
