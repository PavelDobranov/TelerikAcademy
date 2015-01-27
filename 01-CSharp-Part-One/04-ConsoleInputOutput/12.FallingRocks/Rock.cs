namespace FallingRocksGame
{
    using System;

    public class Rock : GameObject
    {
        private const int MinColorCode = 0;
        private const int MaxColorCode = 16;

        private int speed = 1;
        private char[] symbols = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
        private Random randomGenerator = new Random();
        
        public Rock(int positionX, int positionY) : base(positionX, positionY)
        {
            this.Speed = speed;
            this.Symbol = GetRandomSymbol();
            this.Color = GetRandomColor();
        }

        public void MoveDown()
        {
            this.PositionY += this.Speed;
        }

        private char GetRandomSymbol()
        {
            int randomSymbolPosition = randomGenerator.Next(0, symbols.Length);

            return symbols[randomSymbolPosition];
        }

        private ConsoleColor GetRandomColor()
        {
            return (ConsoleColor)randomGenerator.Next(MinColorCode, MaxColorCode);
        }
    }
}