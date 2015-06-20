// Problem 8. Catalan Numbers
// Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

public class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter number [n] [0 ≤ n ≤ 100]: ");
        int numberN = int.Parse(Console.ReadLine());

        if (numberN > 0 && numberN < 100)
        {
            BigInteger numerator = 1;
            BigInteger divider = 1;

            for (int i = 2 * numberN; i > numberN + 1; i--)
            {
                numerator *= i;
            }

            for (int i = 1; i <= numberN; i++)
            {
                divider *= i;
            }

            BigInteger result = numerator / divider;

            Console.WriteLine("Catalan(15) = {1}", numberN, result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}