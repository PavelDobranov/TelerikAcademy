// Problem 19.* Permutations of set
// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

using System;

class PermutationsOfSet
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());

        int[] array = new int[numberN];
        bool[] used = new bool[array.Length];

        Console.Write("Result: ");
        Permutation(array, used, 0);
    }

    static void Permutation(int[] array, bool[] used, int position)
    {
        if (position == array.Length)
        {
            Check(array);
            return;
        }

        for (int j = 0; j < array.Length; j++)
        {
            if (used[j]) continue;

            array[position] = j;

            used[j] = true;
            Permutation(array, used, position + 1);
            used[j] = false;
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