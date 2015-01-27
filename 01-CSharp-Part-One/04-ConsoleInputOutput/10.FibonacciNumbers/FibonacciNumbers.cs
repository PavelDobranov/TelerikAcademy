// Problem 10. Fibonacci Numbers
// Write a program that reads a number n and prints on the console the first n members
// of the Fibonacci sequence (at a single line, separated by comma and space - ,)
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int sequenceEndMember = int.Parse(Console.ReadLine());

        int aMember = 0;
        int bMember = 1;
     
        Console.Write("{0} {1} ", aMember, bMember);

        for (int i = 2; i < sequenceEndMember; i++)
        {
            int cMember = aMember + bMember;
            aMember = bMember;
            bMember = cMember;

            Console.Write("{0} ", cMember);
        }

        Console.WriteLine();
    }
}