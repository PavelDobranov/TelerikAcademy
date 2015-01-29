// Problem 3. Check for a Play Card
// Classical play cards use the following signs to designate the card 
// face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
// Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;

class CheckForPlayCard
{
    static void Main()
    {
        Console.Write("Enter a card face: ");
        string card = Console.ReadLine();

        bool isValidCardSign = CheckForValidCard(card);

        Console.WriteLine("Valid card sign?: {0}", isValidCardSign ? "yes" : "no");
    }

    static bool CheckForValidCard(string card)
    {
        switch (card)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A": return true;
            default: return false;
        }
    }
}