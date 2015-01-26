using System;

class CardWars
{
    static void Main()
    {
        int numberOfGames = int.Parse(Console.ReadLine());
        int cardsInHand = 3;

        int firstPlayerTotalPoints = 0;
        int secondPlayerTotalPoints = 0;

        int firstPlayerWins = 0;
        int secondPlayerWins = 0;

        for (int game = 0; game < numberOfGames; game++)
        {
            int firstPlayerGamePoints = 0;
            int secondPlayerGamePoints = 0;

            bool firstPlayerDrownX = false;
            bool secondPlayerDrownX = false;

            for (int card = 0; card < cardsInHand; card++)
            {
                string currentCard = Console.ReadLine();

                if (currentCard == "Z")
                {
                    firstPlayerTotalPoints *= 2;
                }
                else if (currentCard == "Y")
                {
                    firstPlayerTotalPoints -= 200;

                    if (firstPlayerTotalPoints < 0)
                    {
                        firstPlayerTotalPoints = 0;
                    }
                }
                else if (currentCard == "X")
                {
                    firstPlayerDrownX = true;
                    break;
                }
                else
                {
                    firstPlayerGamePoints += GetCardPoints(currentCard);
                }
            }

            for (int card = 0; card < cardsInHand; card++)
            {
                string currentCard = Console.ReadLine();

                if (currentCard == "Z")
                {
                    secondPlayerTotalPoints *= 2;
                }
                else if (currentCard == "Y")
                {
                    secondPlayerTotalPoints -= 200;

                    if (secondPlayerTotalPoints < 0)
                    {
                        secondPlayerTotalPoints = 0;
                    }
                }
                else if (currentCard == "X")
                {
                    secondPlayerDrownX = true;
                    break;
                }
                else
                {
                    secondPlayerGamePoints += GetCardPoints(currentCard);
                }
            }

            if (firstPlayerDrownX && !secondPlayerDrownX)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }

            if (secondPlayerDrownX && !firstPlayerDrownX)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }

            if (firstPlayerDrownX && secondPlayerDrownX)
            {
                firstPlayerTotalPoints += 50;
                secondPlayerTotalPoints += 50;

                firstPlayerDrownX = false;
                secondPlayerDrownX = false;
                continue;
            }

            if (firstPlayerGamePoints > secondPlayerGamePoints)
            {
                firstPlayerTotalPoints += firstPlayerGamePoints;
                firstPlayerWins++;
                continue;
            }

            if (firstPlayerGamePoints < secondPlayerGamePoints)
            {
                secondPlayerTotalPoints += secondPlayerGamePoints;
                secondPlayerWins++;
                continue;
            }

            if (firstPlayerGamePoints == secondPlayerGamePoints)
            {
                continue;
            }
        }

        if (firstPlayerTotalPoints > secondPlayerTotalPoints)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", firstPlayerTotalPoints);
            Console.WriteLine("Games won: {0}", firstPlayerWins);
        }

        if (firstPlayerTotalPoints < secondPlayerTotalPoints)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", secondPlayerTotalPoints);
            Console.WriteLine("Games won: {0}", secondPlayerWins);
        }

        if (firstPlayerTotalPoints == secondPlayerTotalPoints)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", firstPlayerTotalPoints);
        }
    }
    
    static int GetCardPoints(string card)
    {
        int points = 0;

        switch (card)
        {
            case "2": points = 10; break;
            case "3": points = 9; break;
            case "4": points = 8; break;
            case "5": points = 7; break;
            case "6": points = 6; break;
            case "7": points = 5; break;
            case "8": points = 4; break;
            case "9": points = 3; break;
            case "10": points = 2; break;
            case "A": points = 1; break;
            case "J": points = 11; break;
            case "Q": points = 12; break;
            case "K": points = 13; break;
        }

        return points;
    }
}