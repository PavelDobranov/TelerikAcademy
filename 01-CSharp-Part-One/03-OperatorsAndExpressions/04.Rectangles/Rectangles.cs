// Problem 4. Rectangles
// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter rectangle's width: ");
        double rectangleWidth = double.Parse(Console.ReadLine());

        Console.Write("Please enter rectangle's height: ");
        double rectangleHeight = double.Parse(Console.ReadLine());

        double rectanglePerimeter = 2 * rectangleWidth + 2 * rectangleHeight;
        double rectangleArea = rectangleWidth * rectangleHeight;

        Console.WriteLine("Perimeter: {0}", rectanglePerimeter);
        Console.WriteLine("Area: {0}", rectangleArea);
    }
}