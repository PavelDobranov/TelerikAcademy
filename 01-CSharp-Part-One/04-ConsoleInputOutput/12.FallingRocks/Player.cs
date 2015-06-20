namespace FallingRocksGame
{
    using System;

    public class Player : GameObject
    {
        private int speed = 1;
        private char symbol = '@';

        public Player(int positionX, int positionY)
            : base(positionX, positionY)
        {
            this.Speed = speed;
            this.Symbol = symbol;
            this.Color = ConsoleColor.Yellow;
        }

        public void MoveRight()
        {
            this.PositionX += base.Speed;
        }

        public void MoveLeft()
        {
            this.PositionX -= this.Speed;
        }
    }
}