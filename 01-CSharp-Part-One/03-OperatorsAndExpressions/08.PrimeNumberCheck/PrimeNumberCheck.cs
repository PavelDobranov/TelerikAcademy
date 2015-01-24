// Problem 8. Prime Number Check
// Write an expression that checks if given positive integer number n (n <= 100) 
// is prime (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a positive integer value [n = 0 to 100]: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0 && number <= 100)
        {
            Console.WriteLine("Is prime? : {0}", IsPrimeNumber(number));
        }
        else
        {
            Console.WriteLine("The number is not in range: [n = 0 to 100]");
        }
    }

    static bool IsPrimeNumber(int number)
    {
        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i * i < number; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}