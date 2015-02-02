namespace GameOfPage
{
    using System;

    class GameOfPageSolution
    {
        private const int TraySize = 16;
        private const double CookieCost = 1.79;

        private static bool[,] cookieTray = new bool[TraySize, TraySize];
        private static double bill = 0;

        private static void Main()
        {
            FillCookieTray();

            string command = "";
            int locationRow = 0;
            int locationCol = 0;

            while (command != "paypal")
            {
                command = Console.ReadLine();

                switch (command)
                {
                    case "what is":
                        locationRow = int.Parse(Console.ReadLine());
                        locationCol = int.Parse(Console.ReadLine());

                        WhatIsAtGivenLocation(locationRow, locationCol);
                        break;
                    case "buy":
                        locationRow = int.Parse(Console.ReadLine());
                        locationCol = int.Parse(Console.ReadLine());

                        BuyAtGivenLocation(locationRow, locationCol);
                        break;
                    case "paypal":
                        Console.WriteLine("{0:F2}", bill);
                        break;
                }
            }
        }

        private static void FillCookieTray()
        {
            for (int row = 0; row < TraySize; row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < TraySize; col++)
                {
                    if (currentRow[col] == '1')
                    {
                        cookieTray[row, col] = true;
                    }
                }
            }
        }

        private static void WhatIsAtGivenLocation(int locationRow, int locationCol)
        {
            if (cookieTray[locationRow, locationCol])
            {
                if (isCookie(locationRow, locationCol))
                {
                    Console.WriteLine("cookie");
                }
                else if (isCrumb(locationRow, locationCol))
                {
                    Console.WriteLine("cookie crumb");
                }
                else
                {
                    Console.WriteLine("broken cookie");
                }
            }
            else
            {
                Console.WriteLine("smile");
            }
        }

        private static void BuyAtGivenLocation(int locationRow, int locationCol)
        {
            if (cookieTray[locationRow, locationCol])
            {
                if (isCookie(locationRow, locationCol))
                {
                    BuyCookie(locationRow, locationCol);
                    bill += CookieCost;
                }
                else
                {
                    Console.WriteLine("page");
                }
            }
            else
            {
                Console.WriteLine("smile");
            }
        }

        private static bool isCookie(int locationRow, int locationCol)
        {
            if (locationRow == 0 || locationRow == cookieTray.GetLength(0) - 1 || locationCol == 0 || locationCol == cookieTray.GetLength(1) - 1)
            {
                return false;
            }

            for (int row = locationRow - 1; row <= locationRow + 1; row++)
            {
                for (int col = locationCol - 1; col <= locationCol + 1; col++)
                {
                    if (!cookieTray[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool isCrumb(int locationRow, int locationCol)
        {
            int startRow = locationRow == 0 ? 0 : locationRow - 1;
            int endRow = locationRow == cookieTray.GetLength(0) - 1 ? cookieTray.GetLength(0) - 1 : locationRow + 1;

            int startCol = locationCol == 0 ? 0 : locationCol - 1;
            int endCol = locationCol == cookieTray.GetLength(1) - 1 ? cookieTray.GetLength(1) - 1 : locationCol + 1;


            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    if (cookieTray[row, col] && row != locationRow && col != locationCol)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void BuyCookie(int locationRow, int locationCol)
        {
            for (int row = locationRow - 1; row <= locationRow + 1; row++)
            {
                for (int col = locationCol - 1; col <= locationCol + 1; col++)
                {
                    cookieTray[row, col] = false;
                }
            }
        }
    }
}