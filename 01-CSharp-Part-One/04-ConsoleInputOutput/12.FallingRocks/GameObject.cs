namespace FallingRocksGame
{
    using System;

    public abstract class GameObject
    {
        public GameObject(int positionX, int positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        public int PositionX { get; set; }
 
        public int PositionY { get; set; }

        public int Speed { get; protected set; }

        public char Symbol { get; protected set; }

        public ConsoleColor Color { get; protected set; }
    }
}