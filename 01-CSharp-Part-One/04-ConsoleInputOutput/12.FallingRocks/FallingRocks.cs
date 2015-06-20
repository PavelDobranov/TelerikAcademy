// Problem 12.** Falling Rocks
// Implement the "Falling Rocks" game in the text console.
// A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
// A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
// Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
// Ensure a constant game speed by Thread.Sleep(150).
// Implement collision detection and scoring system.

namespace FallingRocksGame
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class FallingRocks
    {
        static void Main()
        {
            int gameSleepTime = 100;
            int gameFieldWidth = 50;
            int gameFieldHeight = 30;

            int playerStartPositionX = gameFieldWidth / 2;
            int playerStartPositionY = gameFieldHeight - 2;
            int playerScores = 0;
            bool playerHittedByRock = false;

            int rockStartPositionY = 1;

            Player player = new Player(playerStartPositionX, playerStartPositionY);

            List<Rock> rocks = new List<Rock>();

            Random randomGenerator = new Random();

            Renderer renderer = new Renderer();

            renderer.InitGameField(gameFieldWidth, gameFieldHeight);

            while (true)
            {
                renderer.PrintCurrentScores(playerScores);
                renderer.PrintGameObject(player);

                rocks.Add(new Rock(randomGenerator.Next(1, gameFieldWidth - 1), rockStartPositionY));

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                    if (pressedKey.Key == ConsoleKey.LeftArrow && player.PositionX > 1)
                    {
                        renderer.ClearGameObject(player);
                        player.MoveLeft();
                        renderer.PrintGameObject(player);
                    }

                    if (pressedKey.Key == ConsoleKey.RightArrow && player.PositionX < gameFieldWidth - 2)
                    {
                        renderer.ClearGameObject(player);
                        player.MoveRight();
                        renderer.PrintGameObject(player);
                    }
                }

                for (int i = 0; i < rocks.Count; i++)
                {
                    renderer.ClearGameObject(rocks[i]);

                    rocks[i].MoveDown();

                    if (rocks[i].PositionX == player.PositionX && rocks[i].PositionY == player.PositionY)
                    {
                        playerHittedByRock = true;
                        break;
                    }

                    if (rocks[i].PositionY >= gameFieldHeight)
                    {
                        playerScores++;
                        rocks.RemoveAt(i);
                    }
                    else
                    {
                        renderer.PrintGameObject(rocks[i]);
                    }
                }

                if (playerHittedByRock)
                {
                    break;
                }

                Thread.Sleep(gameSleepTime);
            }

            renderer.PrintGameOverScreen(gameFieldWidth, gameFieldHeight, playerScores);
        }
    }
}
