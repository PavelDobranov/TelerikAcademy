// Problem 21.* Combinations of set
// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

﻿using System;

class CombinationsOfSet
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int numberK = int.Parse(Console.ReadLine());

        int[] array = new int[numberK];

        Console.WriteLine("Result: ");
        Combination(array, numberN, 0, 0);
    }

    static void Combination(int[] array, int numberN, int position, int next)
    {
        if (position == array.Length)
        {
            Check(array);
            return;
        }

        for (int i = next; i < numberN; i++)
        {
            array[position] = i;

            Combination(array, numberN, position + 1, i + 1);
        }
    }

    static void Check(int[] array)
    {
        for (int position = 0; position < array.Length; position++)
        {
            Console.Write(array[position] + 1 + (position == array.Length - 1 ? "\n" : " "));
        }
    }
}