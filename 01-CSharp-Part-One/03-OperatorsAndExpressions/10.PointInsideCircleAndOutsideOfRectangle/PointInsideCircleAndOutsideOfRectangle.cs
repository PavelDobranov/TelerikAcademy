// Problem 10. Point Inside a Circle & Outside of a Rectangle
// Write an expression that checks for given point (x, y) if it is within 
// the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInsideCircleAndOutsideOfRectangle
{
    static void Main()
    {
        Console.Write("Enter point \"X\" coordinate: ");
        double pointX = double.Parse(Console.ReadLine());

        Console.Write("Enter point \"Y\" coordinate: ");
        double pointY = double.Parse(Console.ReadLine());

        string result = IsPointWithinCircle(pointX, pointY) && IsPointOutOfRectangle(pointX, pointY) ? "yes" : "no";

        Console.WriteLine("Inside a circle & outside of a rectangle? : {0}", result);
    }

    static bool IsPointWithinCircle(double pointX, double pointY)
    {
        int circleX = 1;
        int circleY = 1;
        double circleRadius = 1.5;

        double xDelta = pointX - circleX;
        double yDelta = pointY - circleY;

        bool isWithinCircle = (xDelta * xDelta) + (yDelta * yDelta) <= circleRadius * circleRadius;

        return isWithinCircle;
    }

    static bool IsPointOutOfRectangle(double pointX, double pointY)
    {
        int rectangleTop = 1;
        int rectangleLeft = -1;
        int rectangleWidth = 6;
        int rectangleHeight = 2;

        int rectangleBottom = rectangleTop - rectangleHeight;
        int rectangleRight = rectangleLeft + rectangleWidth;

        bool isOutOfRectangle = pointX > rectangleRight || pointX < rectangleLeft || pointY > rectangleTop || pointY < rectangleBottom;

        return isOutOfRectangle;
    }
}