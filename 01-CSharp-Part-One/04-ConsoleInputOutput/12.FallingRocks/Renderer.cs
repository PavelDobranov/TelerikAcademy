namespace FallingRocksGame
{
    using System;

    public class Renderer
    {
        public void InitGameField(int gameFieldWidth, int gameFieldHeight)
        {
            Console.Title = "Falling Rocks";
            Console.BufferWidth = Console.WindowWidth = gameFieldWidth;
            Console.BufferHeight = Console.WindowHeight = gameFieldHeight;
            Console.CursorVisible = false;
        }

        public void PrintGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.PositionX, gameObject.PositionY);
            Console.ForegroundColor = gameObject.Color;
            Console.Write(gameObject.Symbol);
            Console.ResetColor();
        }

        public void ClearGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.PositionX, gameObject.PositionY);
            Console.Write(' ');
        }

        public void PrintCurrentScores(int scores)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Scores: {0}", scores);
        }

        public void PrintGameOverScreen(int gameFieldWidth, int gameFieldHeight, int scores)
        {
            string message = "GAME OVER";
            int messagePositionX = (gameFieldWidth - message.Length) / 2;
            int messagePositionY = gameFieldHeight / 2;

            Console.Beep(600, 100);
            Console.Beep(200, 600);
            Console.Clear();
            PrintCurrentScores(scores);
            Console.SetCursorPosition(messagePositionX, messagePositionY);
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}