// Problem 2. Bonus Score
// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//  - If the score is between 1 and 3, the program multiplies it by 10.
//  - If the score is between 4 and 6, the program multiplies it by 100.
//  - If the score is between 7 and 9, the program multiplies it by 1000.
//  - If the score is 0 or more than 9, the program prints “invalid score”.

using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score: ");
        int score = int.Parse(Console.ReadLine());

        string result = AddBonusScore(score);

        Console.WriteLine("Result: {0}", result);
    }

    static string AddBonusScore(int score)
    {
        if (score >= 0 && score <= 3)
        {
            return (score * 10).ToString();
        }
        else if (score >= 4 && score <= 6)
        {
            return (score * 100).ToString();
        }
        else if (score >= 7 && score <= 9)
        {
            return (score * 1000).ToString();
        }
        else
        {
            return "invalid score";
        }
    }
}