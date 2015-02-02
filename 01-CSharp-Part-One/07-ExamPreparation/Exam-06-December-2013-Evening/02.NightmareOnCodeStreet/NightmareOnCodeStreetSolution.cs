namespace NightmareOnCodeStreet
{
    using System;

    class NightmareOnCodeStreetSolution
    {
        private static void Main()
        {
            string inputText = Console.ReadLine();

            PrintOddPositionDigitsSum(inputText);
        }

        private static void PrintOddPositionDigitsSum(string text)
        {
            int oddPositionDigitsSum = 0;
            int oddPositionDigitsCount = 0;

            int currentSymbol = 0;

            foreach (char symbol in text)
            {
                if (currentSymbol % 2 != 0 && Char.IsDigit(symbol))
                {
                    oddPositionDigitsSum += (int)(symbol - '0');
                    oddPositionDigitsCount++;
                }

                currentSymbol++;
            }

            Console.WriteLine("{0} {1}", oddPositionDigitsCount, oddPositionDigitsSum);
        }
    }
}