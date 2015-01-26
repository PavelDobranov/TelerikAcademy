using System;
using System.Numerics;
using System.Text;

class Secrets
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        if (number < 0)
        {
            number *= -1;
        }

        int specialSum = GetSpecialSum(number);
        string secretAlphaSequence = GetSecretSequence(number, specialSum);

        Console.WriteLine(specialSum);
        Console.WriteLine(secretAlphaSequence);
    }

    static int GetSpecialSum(BigInteger number)
    {
        int currentPosition = 0;
        int specialSum = 0;

        while (number > 0)
        {
            currentPosition++;

            int currentDigit = (int)(number % 10);

            if (currentPosition % 2 != 0)
            {
                specialSum += currentDigit * (currentPosition * currentPosition);
            }
            else
            {
                specialSum += (currentDigit * currentDigit) * currentPosition;
            }

            number /= 10;
        }

        return specialSum;
    }

    static string GetSecretSequence(BigInteger number, int specialSum)
    {
        StringBuilder secretSequence = new StringBuilder();

        if (specialSum % 10 == 0)
        {
            secretSequence.AppendFormat("{0} has no secret alpha-sequence", number);
        }
        else
        {
            char firstAlphabetLetter = 'A';
            char lastAlphabetLetter = 'Z';
            int alphabetLength = 26;

            char currentSecretLetter = (char)(specialSum % alphabetLength + firstAlphabetLetter);
            int secretSequenceLength = specialSum % 10;

            for (int i = 0; i < secretSequenceLength; i++)
            {
                if (currentSecretLetter > lastAlphabetLetter)
                {
                    currentSecretLetter = firstAlphabetLetter;
                }

                secretSequence.Append(currentSecretLetter);

                currentSecretLetter++;
            }
        }

        return secretSequence.ToString();
    }
}