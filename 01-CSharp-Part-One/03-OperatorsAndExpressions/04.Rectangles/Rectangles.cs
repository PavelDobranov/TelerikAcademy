// Problem 4. Rectangles
// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

public class Rectangles
{
    static void Main()
    {
        Console.Write("Enter rectangle's width: ");
        double rectangleWidth = double.Parse(Console.ReadLine());

        Console.Write("Enter rectangle's height: ");
        double rectangleHeight = double.Parse(Console.ReadLine());

        double rectanglePerimeter = CalculateRectangleArea(rectangleWidth, rectangleHeight);
        double rectangleArea = CalculateRectangleArea(rectangleWidth, rectangleHeight);

        Console.WriteLine("Perimeter: {0}", rectanglePerimeter);
        Console.WriteLine("Area: {0}", rectangleArea);
    }

    private static double CalculateRectanglePerimeter(double rectangleWidth, double rectangleHeight)
    {
        return 2 * rectangleWidth + 2 * rectangleHeight;
    }

    private static double CalculateRectangleArea(double rectangleWidth, double rectangleHeight)
    {
        return rectangleWidth * rectangleHeight;
    }
}