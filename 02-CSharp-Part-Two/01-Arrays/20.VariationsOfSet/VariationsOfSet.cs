// Problem 20.* Variations of set
// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

﻿using System;

class VariationsOfSet
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int numberK = int.Parse(Console.ReadLine());

        int[] array = new int[numberK];

        Console.WriteLine("Result: ");
        Variation(array, numberN, 0);
    }

    static void Variation(int[] array, int numberN, int position)
    {
        if (position == array.Length)
        {
            Check(array);
            return;
        }

        for (int i = 0; i < numberN; i++)
        {
            array[position] = i;

            Variation(array, numberN, position + 1);
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