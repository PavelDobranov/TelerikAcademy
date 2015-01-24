// Problem 7. Point in a Circle
// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter point \"X\" coordinate: ");
        double pointX = double.Parse(Console.ReadLine());

        Console.Write("Exnter point \"Y\" coordinate: ");
        double pointY = double.Parse(Console.ReadLine());

        bool isWithinCircle = IsPointWithinCircle(pointX, pointY);

        Console.WriteLine("Is inside a circle? : {0}", isWithinCircle);  
    }

    static bool IsPointWithinCircle(double pointX, double pointY)
    {
        int circleX = 0;
        int circleY = 0;
        double circleRadius = 2;

        double xDelta = pointX - circleX;
        double yDelta = pointY - circleY;

        bool isWithinCircle = (xDelta * xDelta) + (yDelta * yDelta) <= circleRadius * circleRadius;

        return isWithinCircle;
    }
}