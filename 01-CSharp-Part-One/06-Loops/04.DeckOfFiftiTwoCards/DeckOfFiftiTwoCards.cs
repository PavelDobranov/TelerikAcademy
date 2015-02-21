// Problem 4. Print a Deck of 52 Cards
// Write a program that generates and prints all possible cards from a standard deck
// of 52 cards(without the jokers).
// The cards should be printed using the classical notation 
// (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
// The card faces should start from 2 to A.
// Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
// Use 2 nested for-loops and a switch-case statement.

using System;

class DeckOfFiftiTwoCards
{
    static void Main()
    {
        char clubs = '\u2663';
        char diamonds = '\u2666';
        char hearts = '\u2665';
        char spades = '\u2660';

        char[] cardSuits = { clubs, diamonds, hearts, spades };

        int startCardFace = 2;
        int endCardFace = 14;

        for (int face = startCardFace; face <= endCardFace; face++)
        {
            for (int suit = 0; suit < cardSuits.Length; suit++)
            {
                switch (face)
                {
                    case 11: Console.Write("J{0} ", cardSuits[suit]); break;
                    case 12: Console.Write("Q{0} ", cardSuits[suit]); break;
                    case 13: Console.Write("K{0} ", cardSuits[suit]); break;
                    case 14: Console.Write("A{0} ", cardSuits[suit]); break;
                    default: Console.Write("{0}{1} ", face, cardSuits[suit]); break;
                }
            }

            Console.WriteLine();
        }
    }
}